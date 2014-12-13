// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ItemReference.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
    /// <summary>
    /// Used to returns the items that have a reference to the given item.
    /// </summary>
    public class ItemReference
    {
		/// <summary>
		/// Gets or sets the field.
		/// </summary>
		/// <value>The field.</value>
        [JsonProperty("field")]
        public ItemFieldMicro Field { get; set; }

		/// <summary>
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
        [JsonProperty("app")]
        public Application App { get; set; }

		/// <summary>
		/// Gets or sets the items.
		/// </summary>
		/// <value>The items.</value>
        [JsonProperty("items")]
        public List<ItemMicro> Items { get; set; }
    }
}
