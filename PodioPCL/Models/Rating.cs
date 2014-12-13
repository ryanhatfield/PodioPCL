// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Rating.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Rating.
	/// </summary>
    public class Rating
    {
		/// <summary>
		/// Gets or sets the approved.
		/// </summary>
		/// <value>The approved.</value>
        [JsonProperty("approved")]
        public RatingType Approved { get; set; }

		/// <summary>
		/// Gets or sets the RSVP.
		/// </summary>
		/// <value>The RSVP.</value>
        [JsonProperty("rsvp")]
        public RatingType Rsvp { get; set; }

		/// <summary>
		/// Gets or sets the fivestar.
		/// </summary>
		/// <value>The fivestar.</value>
        [JsonProperty("fivestar")]
        public RatingType Fivestar { get; set; }

		/// <summary>
		/// Gets or sets the yes no.
		/// </summary>
		/// <value>The yes no.</value>
        [JsonProperty("yesno")]
        public RatingType YesNo { get; set; }

		/// <summary>
		/// Gets or sets the thumbs.
		/// </summary>
		/// <value>The thumbs.</value>
        [JsonProperty("thumbs")]
        public RatingType Thumbs { get; set; }

		/// <summary>
		/// Gets or sets the like.
		/// </summary>
		/// <value>The like.</value>
        [JsonProperty("like")]
        public RatingType Like { get; set; }
    }
}
