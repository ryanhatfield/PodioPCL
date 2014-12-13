// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ImporterInfo.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ImporterInfo.
	/// </summary>
    public class ImporterInfo
    {
		/// <summary>
		/// Gets or sets the row count.
		/// </summary>
		/// <value>The row count.</value>
        [JsonProperty("row_count")]
        public int RowCount { get; set; }

		/// <summary>
		/// Gets or sets the columns.
		/// </summary>
		/// <value>The columns.</value>
        [JsonProperty("columns")]
        List<FileColumn> Columns { get; set; }
    }
	/// <summary>
	/// Class FileColumn.
	/// </summary>
    public class FileColumn
    {
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
        [JsonProperty("id")]
        public int Id { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
