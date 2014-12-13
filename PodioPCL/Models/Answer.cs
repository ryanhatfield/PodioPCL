// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Answer.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Answer.
	/// </summary>
    public class Answer
    {
		/// <summary>
		/// Gets or sets the question option identifier.
		/// </summary>
		/// <value>The question option identifier.</value>
        [JsonProperty("question_option_id")]
        public int questionOptionId { get; set; }

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		/// <value>The user.</value>
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
