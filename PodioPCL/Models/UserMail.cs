// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="UserMail.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class UserMail.
	/// </summary>
	public class UserMail
	{
		/// <summary>
		/// Gets or sets the mail.
		/// </summary>
		/// <value>The mail.</value>
		[JsonProperty("mail")]
		public string Mail { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="UserMail"/> is verified.
		/// </summary>
		/// <value><c>true</c> if verified; otherwise, <c>false</c>.</value>
		[JsonProperty("verified")]
		public bool Verified { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="UserMail"/> is primary.
		/// </summary>
		/// <value><c>true</c> if primary; otherwise, <c>false</c>.</value>
		[JsonProperty("primary")]
		public bool Primary { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="UserMail"/> is disabled.
		/// </summary>
		/// <value><c>true</c> if disabled; otherwise, <c>false</c>.</value>
		[JsonProperty("disabled")]
		public bool Disabled { get; set; }
	}
}
