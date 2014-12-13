// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ItemField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PodioPCL.Utils.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ItemField.
	/// </summary>
	[JsonConverter(typeof(ItemFieldConverter))]
	public class ItemField
	{
		/// <summary>
		/// Gets or sets the field identifier.
		/// </summary>
		/// <value>The field identifier.</value>
		[JsonProperty("field_id")]
		public int? FieldId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
		[JsonProperty("external_id")]
		public string ExternalId { get; set; }

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
		[JsonProperty("label")]
		public string Label { get; set; }

		/// <summary>
		/// Gets or sets the values.
		/// </summary>
		/// <value>The values.</value>
		[JsonProperty("values")]
		public JArray Values { get; set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
		[JsonProperty("config")]
		public FieldConfig Config { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// Determines whether the specified key has value.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns><c>true</c> if the specified key has value; otherwise, <c>false</c>.</returns>
		public bool HasValue(string key = null)
		{
			return this.Values != null
				&& this.Values.Any()
				&& (key == null ||
				(this.Values.First() != null &&
				this.Values.First()[key] != null));
		}

		/// <summary>
		/// Gets the setting.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns>System.Object.</returns>
		public object GetSetting(string key)
		{
			if (this.Config.Settings != null)
			{
				var settings = this.Config.Settings;
				return settings[key];
			}

			return null;
		}

		/// <summary>
		/// Values as.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="value">The value.</param>
		/// <param name="key">The key.</param>
		/// <returns>T.</returns>
		protected T valueAs<T>(JToken value, string key)
			where T : class, new()
		{
			if (value != null && value[key] != null)
				return value[key].ToObject<T>();

			return null;
		}

		/// <summary>
		/// Valueses as.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>List&lt;T&gt;.</returns>
		protected List<T> valuesAs<T>(List<T> list)
			where T : class, new()
		{
			if (list == null)
			{
				list = new List<T>();
				if (this.Values != null)
				{
					foreach (var itemAttributes in this.Values)
					{
						var obj = this.valueAs<T>(itemAttributes, "value");
						list.Add(obj);
					}
				}
			}
			return list;
		}

		/// <summary>
		/// Ensures the values initialized.
		/// </summary>
		/// <param name="includeFirstChildDict">if set to <c>true</c> [include first child dictionary].</param>
		protected void ensureValuesInitialized(bool includeFirstChildDict = false)
		{
			if (this.Values == null)
			{
				this.Values = new JArray();
			}
			if (includeFirstChildDict && this.Values.Count == 0)
			{
				this.Values.Add(new JObject());
			}
		}

		/// <summary>
		/// Converts to.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns>T.</returns>
		public T ConvertTo<T>() where T : ItemField, new()
		{
			var toItem = new T();
			toItem.Config = Config;
			toItem.ExternalId = ExternalId;
			toItem.FieldId = FieldId;
			toItem.Label = Label;
			toItem.Status = Status;
			toItem.Type = Type;
			toItem.Values = Values;
			return toItem;
		}
	}
}
