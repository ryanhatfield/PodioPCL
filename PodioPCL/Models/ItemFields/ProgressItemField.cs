// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ProgressItemField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;

namespace PodioPCL.Models.ItemFields
{
	/// <summary>
	/// Class ProgressItemField.
	/// </summary>
    public class ProgressItemField : ItemField
    {
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        public int? Value
        {
            get
            {
                if (this.HasValue("value"))
                {
                    return Convert.ToInt32((Int64)this.Values.First()["value"]);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                ensureValuesInitialized(true);
                this.Values.First()["value"] = value;
            }
        }

    }

}
