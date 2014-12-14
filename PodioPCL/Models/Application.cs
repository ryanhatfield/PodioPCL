// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Application.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using PodioPCL.Utils.ApplicationFields;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Application.
	/// </summary>
    public class Application
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="Application"/> class.
		/// </summary>
        public Application()
        {
            this.Fields = new List<ApplicationField>();
        }

		/// <summary>
		/// Gets or sets the application identifier.
		/// </summary>
		/// <value>The application identifier.</value>
        [JsonProperty("app_id")]
        public int AppId { get; set; }

		/// <summary>
		/// Gets the original.
		/// </summary>
		/// <value>The original.</value>
        [JsonProperty("original")]
        public int? Original { get; private set; }

		/// <summary>
		/// Gets the original revision.
		/// </summary>
		/// <value>The original revision.</value>
        [JsonProperty("original_revision")]
        public int? OriginalRevision { get; private set; }

		/// <summary>
		/// Gets the status.
		/// </summary>
		/// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; private set; }

		/// <summary>
		/// Gets the icon.
		/// </summary>
		/// <value>The icon.</value>
        [JsonProperty("icon")]
        public string Icon { get; private set; }

		/// <summary>
		/// Gets the icon identifier.
		/// </summary>
		/// <value>The icon identifier.</value>
        [JsonProperty("icon_id")]
        public int? IconId { get; private set; }

		/// <summary>
		/// Gets or sets the space identifier.
		/// </summary>
		/// <value>The space identifier.</value>
        [JsonProperty("space_id")]
        public int? SpaceId { get; set; }

		/// <summary>
		/// Gets the owner identifier.
		/// </summary>
		/// <value>The owner identifier.</value>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; private set; }

		/// <summary>
		/// Gets the owner.
		/// </summary>
		/// <value>The owner.</value>
        [JsonProperty("owner")]
        public Profile Owner { get; private set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
        [JsonProperty("config")]
        public ApplicationConfiguration Config { get; set; }

		/// <summary>
		/// Gets a value indicating whether this <see cref="Application"/> is subscribed.
		/// </summary>
		/// <value><c>true</c> if subscribed; otherwise, <c>false</c>.</value>
        [JsonProperty("subscribed")]
        public bool Subscribed { get; private set; }

		/// <summary>
		/// Gets the rights.
		/// </summary>
		/// <value>The rights.</value>
        [JsonProperty("rights")]
        public string[] Rights { get; private set; }

		/// <summary>
		/// Gets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string Link { get; private set; }

		/// <summary>
		/// Gets or sets the link add.
		/// </summary>
		/// <value>The link add.</value>
        [JsonProperty("link_add")]
        public string LinkAdd { get; set; }

		/// <summary>
		/// Gets the URL add.
		/// </summary>
		/// <value>The URL add.</value>
        [JsonProperty("url_add")]
        public string UrlAdd { get; private set; }

		/// <summary>
		/// Gets the token.
		/// </summary>
		/// <value>The token.</value>
        [JsonProperty("token")]
        public string Token { get; private set; }

		/// <summary>
		/// Gets the URL label.
		/// </summary>
		/// <value>The URL label.</value>
        [JsonProperty("url_label")]
        public string UrlLabel { get; private set; }

		/// <summary>
		/// Gets the mailbox.
		/// </summary>
		/// <value>The mailbox.</value>
        [JsonProperty("mailbox")]
        public string Mailbox { get; private set; }

		/// <summary>
		/// Gets or sets the integration.
		/// </summary>
		/// <value>The integration.</value>
        [JsonProperty("integration")]
        public Integration Integration { get; set; }

		/// <summary>
		/// Gets or sets the fields.
		/// </summary>
		/// <value>The fields.</value>
        [JsonProperty("fields")]
        public List<ApplicationField> Fields { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Application"/> is pinned.
		/// </summary>
		/// <value><c>true</c> if pinned; otherwise, <c>false</c>.</value>
        [JsonProperty("pinned")]
        public bool Pinned { get; set; }
        // When app is returned as part of large collection (e.g. for stream), some config properties is moved to the main object

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the name of the item.
		/// </summary>
		/// <value>The name of the item.</value>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }


		/// <summary>
		/// Only for retrival
		/// <para> for create or update use <see cref="PodioPCL.Models.Application.Field &lt;T&gt;()" /> overload</para>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="externalId">The external identifier.</param>
		/// <returns>T.</returns>
        public T Field<T>(string externalId)
            where T : ApplicationField, new()
        {
            var genericField = this.Fields.Find(field => field.ExternalId == externalId);
            return fieldInstance<T>(genericField);
        }

		/// <summary>
		/// Only for retrival
		/// <para> for create or update use <see cref="PodioPCL.Models.Application.Field &lt;T&gt;()" /> overload</para>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="fieldId">The field identifier.</param>
		/// <returns>T.</returns>
        public T Field<T>(int fieldId)
            where T : ApplicationField, new()
        {
            var genericField = this.Fields.Find(field => field.FieldId == fieldId);
            return fieldInstance<T>(genericField);
        }

		/// <summary>
		/// For application create and update only
		/// <para>Use the other overloads for retrival</para>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns>T.</returns>
        public T Field<T>()
           where T : ApplicationField, new()
        {
            T specificField = new T();
            SetFieldType(specificField);
            this.Fields.Add(specificField);
            return specificField;
        }

		/// <summary>
		/// Fields the instance.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="genericField">The generic field.</param>
		/// <param name="externalId">The external identifier.</param>
		/// <param name="fieldId">The field identifier.</param>
		/// <returns>T.</returns>
        protected T fieldInstance<T>(ApplicationField genericField, string externalId = null, int? fieldId = null)
                    where T : ApplicationField, new()
        {
            T specificField = new T();
            if (genericField != null)
            {
                foreach (var property in genericField.GetType().GetRuntimeProperties())
                {
                    var jsonAttribute = ((JsonPropertyAttribute[])property.GetCustomAttributes(typeof(JsonPropertyAttribute), false));
                    if(jsonAttribute.Length > 0)
                        specificField.GetType().GetRuntimeProperty(property.Name).SetValue(specificField, property.GetValue(genericField, null), null);               
                }
            }
            return specificField;
        }

		/// <summary>
		/// Sets the type of the field.
		/// </summary>
		/// <param name="field">The field.</param>
        private void SetFieldType(ApplicationField field)
        {
            if (field.GetType() == typeof(TextApplicationField))
            {
                field.Type = "text";
            }
            if (field.GetType() == typeof(NumericApplicationField))
            {
                field.Type = "number";
            }
            if (field.GetType() == typeof(StateApplicationField))
            {
                field.Type = "state";
            }
            if (field.GetType() == typeof(ImageApplicationField))
            {
                field.Type = "image";
            }
            if (field.GetType() == typeof(DateApplicationField))
            {
                field.Type = "date";
            }
            if (field.GetType() == typeof(AppReferenceApplicationField))
            {
                field.Type = "app";
            }
            if (field.GetType() == typeof(MoneyApplicationField))
            {
                field.Type = "money";
            }
            if (field.GetType() == typeof(ProgressApplicationField))
            {
                field.Type = "progress";
            }
            if (field.GetType() == typeof(LocationApplicationField))
            {
                field.Type = "location";
            }
            if (field.GetType() == typeof(DurationApplicationField))
            {
                field.Type = "duration";
            }
            if (field.GetType() == typeof(ContactApplicationField))
            {
                field.Type = "contact";
            }
            if (field.GetType() == typeof(CalculationApplicationField))
            {
                field.Type = "calculation";
            }
            if (field.GetType() == typeof(EmbedApplicationField))
            {
                field.Type = "embed";
            }
            if (field.GetType() == typeof(QuestionApplicationField))
            {
                field.Type = "question";
            }
            if (field.GetType() == typeof(CategoryApplicationField))
            {
                field.Type = "category";
            }
            if (field.GetType() == typeof(FileApplicationField))
            {
                field.Type = "file";
            }
        }
    }
}
