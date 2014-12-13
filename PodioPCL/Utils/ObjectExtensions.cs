// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using PodioPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PodioPCL.Utils
{
	/// <summary>
	/// Class ObjectExtensions.
	/// </summary>
    public static class ObjectExtensions
    {
		/// <summary>
		/// Ases the specified source.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source">The source.</param>
		/// <returns>T.</returns>
        public static T As<T>(this IDictionary<string, object> source)
            where T : class, new()
        {
            T someObject = new T();
            return (T)objectFromDict(someObject, source);
        }

		/// <summary>
		/// To the string or null.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns>System.String.</returns>
        public static string ToStringOrNull(this object obj)
        {
            return obj == null ? null : obj.ToString();
        }

		/// <summary>
		/// Changes the type.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj">The object.</param>
		/// <returns>T.</returns>
        public static T ChangeType<T>(this object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }

		/// <summary>
		/// Objects from dictionary.
		/// </summary>
		/// <param name="someObject">Some object.</param>
		/// <param name="source">The source.</param>
		/// <returns>System.Object.</returns>
        private static object objectFromDict(object someObject, IDictionary<string, object> source)
        {
            var propertyMap = new Dictionary<string, PropertyInfo>();
            foreach (var property in someObject.GetType().GetRuntimeProperties())
            {
                var jsonAttribute = ((JsonPropertyAttribute[])property.GetCustomAttributes(typeof(JsonPropertyAttribute), false));
                if (jsonAttribute.Length > 0)
                {
                    var name = jsonAttribute.First().PropertyName;
                    propertyMap[name] = property;
                }
            }

            foreach (KeyValuePair<string, object> item in source)
            {
                //someObject.GetType().GetProperty(item.Key).SetValue(someObject, item.Value, null);
                if (propertyMap.ContainsKey(item.Key))
                {
                    var value = item.Value;
                    if (value is Int64)
                    {
                        // Convert 64 bit ints to 32 bit if required
                        value = Convert.ToInt32(value);
                    }
                    else if (value is Dictionary<string, object> && propertyMap[item.Key].PropertyType != typeof(Dictionary<string, object>))
                    {
                        // Convert nested objects to appropriate type
                        var nestedObject = Activator.CreateInstance(propertyMap[item.Key].PropertyType);
                        value = objectFromDict(nestedObject, (Dictionary<string, object>)value);
                    }
                    else if (propertyMap[item.Key].PropertyType == typeof(DateTime?) && value != null)
                    {
                        // Convert date strings to date times
                        value = DateTime.Parse((string)value);
                    }
                    else if (propertyMap[item.Key].PropertyType == typeof(DateTime) && value != null)
                    {
                        // Convert date strings to date times
                        value = DateTime.Parse((string)value);
                    }
                    else if (value is Newtonsoft.Json.Linq.JArray)
                    {
                        var castedValue = (Newtonsoft.Json.Linq.JArray)value;
                        var propertyType = propertyMap[item.Key].PropertyType;
                        
                        switch (propertyMap[item.Key].PropertyType.Name)
                        {
                            case "String[]":
                                value = castedValue.Select(s => s.ToString()).ToArray();
                                break;
                            case "List`1":
                                if (propertyType.IsGenericParameter && propertyType.GetGenericTypeDefinition() == typeof(List<>))
                                {
                                    Type itemType = propertyType.GenericTypeArguments[0];
                                    if(itemType.Name == "FileAttachment")
                                       value = castedValue.Select(s => s.ToObject<FileAttachment>()).ToList();
                                }

                                break;
                        }
                    }

                    propertyMap[item.Key].SetValue(someObject, value, null);
                }
            }
            return someObject;
        }

		/// <summary>
		/// Gets the property information.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns>PropertyInfo.</returns>
        private static PropertyInfo GetPropertyInfo(Type type, string propertyName)
        {
            PropertyInfo propInfo = null;
            do
            {
				propInfo = type.GetRuntimeProperty(propertyName);
				type = type.GetTypeInfo().BaseType;
            }
            while (propInfo == null && type != null);
            return propInfo;
        }

		/// <summary>
		/// Gets the property value.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns>System.Object.</returns>
        internal static object GetPropertyValue(this object obj, string propertyName)
        {
            Type objType = obj.GetType();
            PropertyInfo propInfo = GetPropertyInfo(objType, propertyName);
            return propInfo.GetValue(obj, null);
        }
    }
}
