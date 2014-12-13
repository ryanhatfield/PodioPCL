// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="CreateUpdateOptions.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class CreateUpdateOptions.
	/// </summary>
    public class CreateUpdateOptions
    {
        /// <summary>
        /// If set to true, no stream events and notifications will be generated. Default value: false
        /// </summary>
        public bool Silent { get; set; }
        /// <summary>
        /// True if hooks should be executed for the change, false otherwise. Default value: true
        /// </summary>
        public bool Hook { get; set; }

		/// <summary>
		/// Gets or sets the fields.
		/// </summary>
		/// <value>The fields.</value>
        public List<string> Fields { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateUpdateOptions"/> class.
		/// </summary>
		/// <param name="silent">if set to <c>true</c> [silent].</param>
		/// <param name="hook">if set to <c>true</c> [hook].</param>
		/// <param name="fields">The fields.</param>
        public CreateUpdateOptions(bool silent = false, bool hook = true, List<string> fields = null)
        {
            Silent = silent;
            Hook = hook;
            Fields = fields;
        }
    }
}
