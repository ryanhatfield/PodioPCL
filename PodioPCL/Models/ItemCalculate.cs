// ***********************************************************************
// Assembly         : PodioAPI
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ItemCalculate.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ItemCalculate.
	/// </summary>
   public class ItemCalculate
    {
		/// <summary>
		/// Gets or sets the total.
		/// </summary>
		/// <value>The total.</value>
       [JsonProperty("total")]
       public double? Total { get; set; }

	   /// <summary>
	   /// Gets or sets the calculation groups.
	   /// </summary>
	   /// <value>The calculation groups.</value>
       [JsonProperty("groups")]
       List<CalculationGroup> CalculationGroups { get; set; }

    }
   /// <summary>
   /// Class CalculationGroup.
   /// </summary>
   public class CalculationGroup
   {
	   /// <summary>
	   /// Gets or sets the value groups.
	   /// </summary>
	   /// <value>The value groups.</value>
       [JsonProperty("groups")]
       public List<ValueGroup> ValueGroups { get; set; }

	   /// <summary>
	   /// Gets or sets the count.
	   /// </summary>
	   /// <value>The count.</value>
       [JsonProperty("count")]
       public double? Count { get; set; }
   }
   /// <summary>
   /// Class ValueGroup.
   /// </summary>
    public class ValueGroup
    {
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        [JsonProperty("value")]
        public string Value { get; set; }

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
