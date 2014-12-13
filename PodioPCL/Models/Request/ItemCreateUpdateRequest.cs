// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ItemCreateUpdateRequest.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class ItemCreateUpdateRequest.
	/// </summary>
    public class ItemCreateUpdateRequest
    {
		/// <summary>
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
        [JsonProperty(PropertyName = "external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

		/// <summary>
		/// Only used for update item
		/// </summary>
		/// <value>The revision.</value>
        [JsonProperty(PropertyName = "revision", NullValueHandling = NullValueHandling.Ignore)]
        public int? Revision { get; set; }

		/// <summary>
		/// Gets or sets the fields.
		/// </summary>
		/// <value>The fields.</value>
        [JsonProperty(PropertyName = "fields", NullValueHandling = NullValueHandling.Ignore)]
        public JArray Fields { get; set; }

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		/// <value>The tags.</value>
        [JsonProperty(PropertyName = "tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

		/// <summary>
		/// Gets or sets the file ids.
		/// </summary>
		/// <value>The file ids.</value>
        [JsonProperty(PropertyName = "file_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> FileIds { get; set; }

		/// <summary>
		/// Gets or sets the reminder.
		/// </summary>
		/// <value>The reminder.</value>
        [JsonProperty(PropertyName = "reminder", NullValueHandling = NullValueHandling.Ignore)]
        public Reminder Reminder { get; set; }

		/// <summary>
		/// Gets or sets the recurrence.
		/// </summary>
		/// <value>The recurrence.</value>
        [JsonProperty(PropertyName = "recurrence", NullValueHandling = NullValueHandling.Ignore)]
        public Recurrence Recurrence { get; set; }

		/// <summary>
		/// Gets or sets the linked account identifier.
		/// </summary>
		/// <value>The linked account identifier.</value>
        [JsonProperty(PropertyName = "linked_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? LinkedAccountId { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty(PropertyName = "ref", NullValueHandling = NullValueHandling.Ignore)]
        public Reference Ref { get; set; }
    }
}

