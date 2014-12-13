// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Flow.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Flow.
	/// </summary>
    public class Flow
    {
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the flow identifier.
		/// </summary>
		/// <value>The flow identifier.</value>
        [JsonProperty("flow_id")]
        public int FlowId { get; set; }

		/// <summary>
		/// Gets or sets the execution count.
		/// </summary>
		/// <value>The execution count.</value>
        [JsonProperty("execution_count")]
        public int ExecutionCount { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty("ref")]
        public Ref Ref { get; set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
        [JsonProperty("config")]
        public JObject Config { get; set; }

		/// <summary>
		/// Gets or sets the effects.
		/// </summary>
		/// <value>The effects.</value>
        [JsonProperty("effects")]
        public List<Effect> effects { get; set; }
    }
}
