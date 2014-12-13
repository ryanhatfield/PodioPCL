// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Seat.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Seat.
	/// </summary>
    public class Seat
    {
		/// <summary>
		/// Gets or sets the employee.
		/// </summary>
		/// <value>The employee.</value>
        [JsonProperty("employee")]
        public string Employee { get; set; }

		/// <summary>
		/// Gets or sets the external.
		/// </summary>
		/// <value>The external.</value>
        [JsonProperty("external")]
        public string External { get; set; }
    }
}
