// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="LocationItemField.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PodioPCL.Models.ItemFields
{
	/// <summary>
	/// Class LocationItemField.
	/// </summary>
    public class LocationItemField : ItemField
    {
		/// <summary>
		/// Gets or sets the locations.
		/// </summary>
		/// <value>The locations.</value>
        public IEnumerable<string> Locations
        {
            get
            {
                if (this.Values != null && this.Values.Any())
                    return new List<string>(this.Values.Select(s => (string)s["value"]));
                else
                    return new List<String>();
            }

            set
            {
                ensureValuesInitialized();
                foreach (var location in value)
                {
                    var jobject = new JObject();
                    jobject["value"] = location;
                    this.Values.Add(jobject);
                }
            }


        }
		/// <summary>
		/// Sets the location.
		/// </summary>
		/// <value>The location.</value>
        public string Location
        {
          

            set
            {
                ensureValuesInitialized();
               
                    var jobject = new JObject();
                    jobject["value"] = value;
                    this.Values.Add(jobject);
                
            }
        }
    }
}
