// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ReferenceGroup.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ReferenceGroup.
	/// </summary>
    public class ReferenceGroup
    {
		/// <summary>
		/// The name of the group; one of {"spaces", "app", "profiles", "created_bys", "created_bys", "tags", "space_contacts", "space_members", "auth_clients", "tasks"}
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
        [JsonProperty(PropertyName = "data")]
        public JObject Data { get; set; }

		/// <summary>
		/// Gets or sets the contents.
		/// </summary>
		/// <value>The contents.</value>
        [JsonProperty(PropertyName = "contents")]
        public JArray Contents { get; set; }
    }
}
