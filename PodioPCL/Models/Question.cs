// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Question.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Question.
	/// </summary>
    public class Question
    {
		/// <summary>
		/// Gets or sets the question identifier.
		/// </summary>
		/// <value>The question identifier.</value>
        [JsonProperty("question_id")]
        public int QuestionId { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
        [JsonProperty("text")]
        public string Text { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty("ref")]
        public Reference Ref { get; set; }

		/// <summary>
		/// Gets or sets the answers.
		/// </summary>
		/// <value>The answers.</value>
        [JsonProperty("answers")]
        public List<QuestionAnswer> Answers { get; set; }

		/// <summary>
		/// Gets or sets the options.
		/// </summary>
		/// <value>The options.</value>
        [JsonProperty("options")]
        public List<QuestionOption> Options { get; set; }
       
    }
}
