// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Recurrence.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Recurrence.
	/// </summary>
    public class Recurrence
    {
		/// <summary>
		/// Gets or sets the recurrence identifier.
		/// </summary>
		/// <value>The recurrence identifier.</value>
        [JsonProperty(PropertyName = "recurrence_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecurrenceId { get; set; }

		/// <summary>
		/// The name of the recurrence, "weekly", "monthly" or "yearly"
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
        [JsonProperty(PropertyName = "config", NullValueHandling = NullValueHandling.Ignore)]
        public RecurrenceConfig Config { get; set; }

		/// <summary>
		/// The step size, 1 or more
		/// </summary>
		/// <value>The step.</value>
        [JsonProperty(PropertyName = "step", NullValueHandling = NullValueHandling.Ignore)]
        public int? Step { get; set; }

		/// <summary>
		/// The latest date the recurrence should take place
		/// </summary>
		/// <value>The until.</value>
        [JsonProperty(PropertyName = "until", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Until { get; set; }
    }

	/// <summary>
	/// Class RecurrenceConfig.
	/// </summary>
    public class RecurrenceConfig
    {
		/// <summary>
		/// List of weekdays ("monday", "tuesday", etc) (for "weekly")
		/// </summary>
		/// <value>The days.</value>
        [JsonProperty(PropertyName = "days", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Days { get; set; }

		/// <summary>
		/// When to repeat, "day_of_week" or "day_of_month" (for "monthly")
		/// </summary>
		/// <value>The repeat on.</value>
        [JsonProperty(PropertyName = "repeat_on", NullValueHandling = NullValueHandling.Ignore)]
        public string RepeatOn { get; set; }
    }
}
