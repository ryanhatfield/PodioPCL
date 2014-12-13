// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="FileResponse.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace PodioPCL.Models
{
	/// <summary>
	/// Class FileResponse.
	/// </summary>
    public class FileResponse
    {
		/// <summary>
		/// Gets or sets the file contents.
		/// </summary>
		/// <value>The file contents.</value>
        public byte[] FileContents { get; set; }
		/// <summary>
		/// Gets or sets the type of the content.
		/// </summary>
		/// <value>The type of the content.</value>
        public string ContentType { get; set; }
		/// <summary>
		/// Gets or sets the length of the content.
		/// </summary>
		/// <value>The length of the content.</value>
        public long ContentLength { get; set; }
    }
}
