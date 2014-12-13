// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="BulkDeletionStatus.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class BulkDeletionStatus.
	/// </summary>
	public class BulkDeletionStatus
	{
		/// <summary>
		/// List of item ids that have been deleted at this point
		/// </summary>
		[JsonProperty(PropertyName = "deleted")]
		public List<int> Deleted { get; set; }

		/// <summary>
		/// List of remaining item ids to be deleted
		/// </summary>
		[JsonProperty(PropertyName = "pending")]
		public List<int> Pending { get; set; }
	}
}
