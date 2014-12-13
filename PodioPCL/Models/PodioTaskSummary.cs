// ***********************************************************************
// Assembly         : PodioAPI
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="PodioTaskSummary.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class PodioTaskSummary.
	/// </summary>
	public class PodioTaskSummary
	{
		/// <summary>
		/// Gets or sets the other.
		/// </summary>
		/// <value>The other.</value>
		[JsonProperty("other")]
		public PodioTaskCollection Other { get; set; }

		/// <summary>
		/// Gets or sets the today.
		/// </summary>
		/// <value>The today.</value>
		[JsonProperty("today")]
		public PodioTaskCollection Today { get; set; }

		/// <summary>
		/// Gets or sets the overdue.
		/// </summary>
		/// <value>The overdue.</value>
		[JsonProperty("overdue")]
		public PodioTaskCollection Overdue { get; set; }
	}
}
