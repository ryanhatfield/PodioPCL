// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ItemMicro.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ItemMicro.
	/// </summary>
    public class ItemMicro
    {
		/// <summary>
		/// Gets or sets the application item identifier.
		/// </summary>
		/// <value>The application item identifier.</value>
        [JsonProperty("app_item_id")]
        public int AppItemId { get; set; }
		/// <summary>
		/// Gets or sets the item identifier.
		/// </summary>
		/// <value>The item identifier.</value>
        [JsonProperty("item_id")]
        public int ItemId { get; set; }
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty("title")]
        public string Title { get; set; }
		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link")]
        public string Link { get; set; }
		/// <summary>
		/// Gets or sets the revision.
		/// </summary>
		/// <value>The revision.</value>
        [JsonProperty("revision")]
        public int Revision { get; set; }
    }
}
