// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Push.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Push.
	/// </summary>
    public class Push
    {
		/// <summary>
		/// Gets or sets the timestamp.
		/// </summary>
		/// <value>The timestamp.</value>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

		/// <summary>
		/// Gets or sets the expires in.
		/// </summary>
		/// <value>The expires in.</value>
        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

		/// <summary>
		/// Gets or sets the channel.
		/// </summary>
		/// <value>The channel.</value>
        [JsonProperty("channel")]
        public string Channel { get; set; }

		/// <summary>
		/// Gets or sets the signature.
		/// </summary>
		/// <value>The signature.</value>
        [JsonProperty("signature")]
        public string Signature { get; set; }
    }
}
