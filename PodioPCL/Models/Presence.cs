// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Presence.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Presence.
	/// </summary>
   public class Presence
    {
		/// <summary>
		/// Gets or sets the reference identifier.
		/// </summary>
		/// <value>The reference identifier.</value>
       [JsonProperty("ref_id")]
       public int? RefId { get; set; }

	   /// <summary>
	   /// Gets or sets the type of the reference.
	   /// </summary>
	   /// <value>The type of the reference.</value>
       [JsonProperty("ref_type")]
       public string RefType { get; set; }

	   /// <summary>
	   /// Gets or sets the signature.
	   /// </summary>
	   /// <value>The signature.</value>
       [JsonProperty("signature")]
       public string Signature { get; set; }

	   /// <summary>
	   /// Gets or sets the user identifier.
	   /// </summary>
	   /// <value>The user identifier.</value>
       [JsonProperty("user_id")]
       public int? UserId { get; set; }
    }
}
