// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ApplicationCreateUpdateRequest.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class ApplicationCreateUpdateRequest.
	/// </summary>
	public class ApplicationCreateUpdateRequest
	{
		/// <summary>
		/// Gets or sets the space identifier.
		/// </summary>
		/// <value>The space identifier.</value>
		[JsonProperty("space_id", NullValueHandling = NullValueHandling.Ignore)]
		public int? SpaceId { get; set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
		[JsonProperty(PropertyName = "config", NullValueHandling = NullValueHandling.Ignore)]
		public ApplicationConfiguration Config { get; set; }

		/// <summary>
		/// Gets or sets the fields.
		/// </summary>
		/// <value>The fields.</value>
		[JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
		public List<ApplicationField> Fields { get; set; }
	}
}
