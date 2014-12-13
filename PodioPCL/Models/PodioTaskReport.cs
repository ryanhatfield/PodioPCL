// ***********************************************************************
// Assembly         : PodioAPI
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="PodioTaskReport.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class PodioTaskReport.
	/// </summary>
	public class PodioTaskReport
	{
		/// <summary>
		/// Gets or sets the reassigned.
		/// </summary>
		/// <value>The reassigned.</value>
		[JsonProperty("reassigned")]
		public PodioTaskType Reassigned { get; set; }

		/// <summary>
		/// Gets or sets the own.
		/// </summary>
		/// <value>The own.</value>
		[JsonProperty("own")]
		public PodioTaskType Own { get; set; }
	}

	/// <summary>
	/// Class PodioTaskType.
	/// </summary>
	public class PodioTaskType
	{
		/// <summary>
		/// Gets or sets the completed yesterday.
		/// </summary>
		/// <value>The completed yesterday.</value>
		[JsonProperty("completed_yesterday")]
		public int CompletedYesterday { get; set; }

		/// <summary>
		/// Gets or sets the upcoming.
		/// </summary>
		/// <value>The upcoming.</value>
		[JsonProperty("upcoming")]
		public int Upcoming { get; set; }

		/// <summary>
		/// Gets or sets the later.
		/// </summary>
		/// <value>The later.</value>
		[JsonProperty("later")]
		public int Later { get; set; }

		/// <summary>
		/// Gets or sets the tomorrow.
		/// </summary>
		/// <value>The tomorrow.</value>
		[JsonProperty("tomorrow")]
		public int Tomorrow { get; set; }

		/// <summary>
		/// Gets or sets the today.
		/// </summary>
		/// <value>The today.</value>
		[JsonProperty("today")]
		public int Today { get; set; }

		/// <summary>
		/// Gets or sets the overdue.
		/// </summary>
		/// <value>The overdue.</value>
		[JsonProperty("overdue")]
		public int Overdue { get; set; }
	}
}
