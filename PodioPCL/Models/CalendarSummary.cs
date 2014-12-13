// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="CalendarSummary.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class CalendarSummary.
	/// </summary>
    public class CalendarSummary
    {
		/// <summary>
		/// Gets or sets the today.
		/// </summary>
		/// <value>The today.</value>
        [JsonProperty("today")]
        public CalendarSummaryGroup Today { get; set; }

		/// <summary>
		/// Gets or sets the upcoming.
		/// </summary>
		/// <value>The upcoming.</value>
        [JsonProperty("upcoming")]
        public CalendarSummaryGroup Upcoming { get; set; }
    }

	/// <summary>
	/// Class CalendarSummaryGroup.
	/// </summary>
    public class CalendarSummaryGroup
    {
		/// <summary>
		/// Gets or sets the total.
		/// </summary>
		/// <value>The total.</value>
        [JsonProperty("total")]
        public int Total { get; set; }

		/// <summary>
		/// Gets or sets the events.
		/// </summary>
		/// <value>The events.</value>
        [JsonProperty("events")]
        public IEnumerable<CalendarEvent> Events { get; set; }
    }
}
