// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="PodioTaskLabel.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class PodioTaskLabel.
	/// </summary>
	public class PodioTaskLabel
	{
		/// <summary>
		/// Gets or sets the label identifier.
		/// </summary>
		/// <value>The label identifier.</value>
		[JsonProperty("label_id")]
		public int LabelId { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// Gets or sets the color.
		/// </summary>
		/// <value>The color.</value>
		[JsonProperty("color")]
		public string Color { get; set; }
	}
}
