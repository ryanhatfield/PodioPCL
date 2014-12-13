// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="PodioOAuth.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using PodioPCL.Models;

namespace PodioPCL.Utils.Authentication
{
	/// <summary>
	/// Authenication response form API
	/// </summary>
    public class PodioOAuth
    {
		/// <summary>
		/// Gets or sets the access token.
		/// </summary>
		/// <value>The access token.</value>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

		/// <summary>
		/// Gets or sets the refresh token.
		/// </summary>
		/// <value>The refresh token.</value>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

		/// <summary>
		/// Gets or sets the expires in.
		/// </summary>
		/// <value>The expires in.</value>
        [JsonProperty(PropertyName = "expires_in")]
        public string ExpiresIn { get; set; }

		/// <summary>
		/// Gets or sets the type of the token.
		/// </summary>
		/// <value>The type of the token.</value>
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty(PropertyName = "ref")]
        public Ref Ref { get; set; }
    }
}
