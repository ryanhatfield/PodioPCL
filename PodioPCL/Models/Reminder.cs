// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Reminder.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Reminder.
	/// </summary>
	public class Reminder
	{
		/// <summary>
		/// Gets the reminder identifier.
		/// </summary>
		/// <value>The reminder identifier.</value>
		[JsonProperty("reminder_id", NullValueHandling = NullValueHandling.Ignore)]
		public int ReminderId { get; private set; }

		/// <summary>
		/// Minutes to remind before the due_date
		/// </summary>
		[JsonProperty("remind_delta", NullValueHandling = NullValueHandling.Ignore)]
		public int ReminderDelta { get; set; }
	}
}
