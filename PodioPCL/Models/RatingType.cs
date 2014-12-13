// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="RatingType.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class RatingType.
	/// </summary>
	public class RatingType
	{
		/// <summary>
		/// Gets or sets the average.
		/// </summary>
		/// <value>The average.</value>
		[JsonProperty("average")]
		public double? Average { get; set; }

		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		/// <value>The count.</value>
		[JsonProperty("counts")]
		//[JsonConverter(typeof(ExpandoObjectConverter))]
		public JObject Count { get; set; }
	}
}
