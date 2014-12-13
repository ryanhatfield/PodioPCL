// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ApplicationRevision.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ApplicationRevision.
	/// </summary>
	public class ApplicationRevision
	{
		/// <summary>
		/// Gets or sets the revision.
		/// </summary>
		/// <value>The revision.</value>
		[JsonProperty("revision")]
		public string Revision { get; set; }
	}
}
