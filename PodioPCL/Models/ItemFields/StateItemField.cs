// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="StateItemField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;

namespace PodioPCL.Models.ItemFields
{
	/// <summary>
	/// Class StateItemField.
	/// </summary>
    public class StateItemField : ItemField
    {
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
        public string Value
        {
            get
            {
                if (this.HasValue("value"))
                {
                    return (string)this.Values.First()["value"];
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
