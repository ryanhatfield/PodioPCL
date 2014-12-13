// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="QuestionOption.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class QuestionOption.
	/// </summary>
    public class QuestionOption
    {
		/// <summary>
		/// Gets or sets the question option identifier.
		/// </summary>
		/// <value>The question option identifier.</value>
        [JsonProperty("question_option_id")]
        public int QuestionOptionId { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
        [JsonProperty("text")]
        public String Text { get; set; }
    }
}
