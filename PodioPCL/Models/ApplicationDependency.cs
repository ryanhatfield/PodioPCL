// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="ApplicationDependency.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PodioPCL.Utils;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class ApplicationDependency.
	/// </summary>
    public class ApplicationDependency
    {

		/// <summary>
		/// Gets or sets the apps.
		/// </summary>
		/// <value>The apps.</value>
        [JsonProperty("apps")]
        public List<Application> Apps { get; set; }

		/// <summary>
		/// Gets or sets the dependency object.
		/// </summary>
		/// <value>The dependency object.</value>
        [JsonProperty("dependencies")]
        private object DependencyObject { get; set; }

		/// <summary>
		/// Gets the dependencies.
		/// </summary>
		/// <value>The dependencies.</value>
        public Dictionary<int, List<int>> Dependencies { get { return LoadDependencies(); } }

		/// <summary>
		/// Loads the dependencies.
		/// </summary>
		/// <returns>Dictionary&lt;System.Int32, List&lt;System.Int32&gt;&gt;.</returns>
        private Dictionary<int, List<int>> LoadDependencies()
        {
            var dictionaryToLoad = new Dictionary<int, List<int>>();
            var reflectedValuesDictionay = (Dictionary<string,object>) this.GetPropertyValue("DependencyObject");
            if (reflectedValuesDictionay.Count > 0)
            {
                foreach (var item in reflectedValuesDictionay)
                {
                    var dependencyValueJArray = (JArray)item.Value;
                    dictionaryToLoad.Add(int.Parse(item.Key), dependencyValueJArray.ToObject<List<int>>());
                }
            }
            return dictionaryToLoad;
        }
    }
}
