// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Effect.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PodioPCL.Models;

namespace PodioPCL
{
	/// <summary>
	/// Class Effect.
	/// </summary>
    public class Effect
    {
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public String Type { get; set; }

		/// <summary>
		/// Gets or sets the effect identifier.
		/// </summary>
		/// <value>The effect identifier.</value>
        [JsonProperty("effect_id")]
        public int EffectId { get; set; }

		/// <summary>
		/// Gets or sets the attributes.
		/// </summary>
		/// <value>The attributes.</value>
        [JsonProperty("attributes")]
        public List<FlowAttribute> Attributes { get; set; }
    }
}
