// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="TaskCreateUpdateRequest.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PodioPCL.Models.Request
{
	/// <summary>
	/// Class PodioTaskCreateUpdateRequest.
	/// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PodioTaskCreateUpdateRequest
    {
        /// <summary>
        /// The text of the task
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// The description of the task
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// True if the task should be private, false otherwise
        /// </summary>
        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; }

        /// <summary>
        /// The due date and time of the task, if any (in local time)
        /// </summary>
        public DateTime? DueDate {
            set 
            { 
                 if (value.HasValue)
                 {
                     DueTimeInternal = value.Value.Date.ToString("yyyy-MM-dd");
                     if (value.Value.TimeOfDay != default(TimeSpan))
                     {
                         this.DueTime = value.Value.ToString("HH:mm");
                     }
                 }
            } 
        }

        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        private string DueTimeInternal { get; set; }

        [JsonProperty("due_time", NullValueHandling = NullValueHandling.Ignore)]
        private string DueTime { get; set; }

        /// <summary>
        /// The due date and time of the task, if any (in UTC)
        /// </summary>
        [JsonProperty("due_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueOn { get; set; }


        [JsonProperty("responsible", NullValueHandling = NullValueHandling.Ignore)]
        internal dynamic Responsible { get; set; }

        /// <summary>
        /// The list of files to attach to this task
        /// </summary>
        [JsonProperty("file_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<int> FileIds { get; set; }

        /// <summary>
        ///  The list of labels in text form
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Labels { get; set; }

        /// <summary>
        /// The list labels in id form
        /// </summary>
        [JsonProperty("label_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<int> LabelIds { get; set; }

        /// <summary>
        /// Optional reminder on this task
        /// </summary>
        [JsonProperty("reminder", NullValueHandling = NullValueHandling.Ignore)]
        public Reminder Reminder { get; set; }

        /// <summary>
        /// The recurrence for the task, if any
        /// </summary>
        [JsonProperty("recurrence", NullValueHandling = NullValueHandling.Ignore)]
        public Recurrence Recurrence { get; set; }

        /// <summary>
        /// Any external id for the task, if from another system
        /// </summary>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The reference type for the task. Only for task update operation
        /// </summary>
        [JsonProperty("ref_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RefType { get; set; }

        /// <summary>
        /// The reference id for the task. Only for task update operation
        /// </summary>
        [JsonProperty("ref_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

		/// <summary>
		/// Sets the responsible.
		/// </summary>
		/// <param name="userIds">The user ids.</param>
        public void SetResponsible(IEnumerable<int> userIds)
        {
            this.Responsible = userIds;
        }

		/// <summary>
		/// Sets the responsible.
		/// </summary>
		/// <param name="userId">The user identifier.</param>
        public void SetResponsible(int userId)
        {
            this.Responsible = userId;
        }

		/// <summary>
		/// Set a list of contact identifier objects
		/// </summary>
		/// <param name="contactIdentifiers">The contact identifiers.</param>
        public void SetResponsible(IEnumerable<Ref> contactIdentifiers)
        {
            this.Responsible = contactIdentifiers;
        }

		/// <summary>
		/// Set a list of contact identifier objects
		/// </summary>
		/// <param name="contactIdentifier">The contact identifier.</param>
        public void SetResponsible(Ref contactIdentifier)
        {
            this.Responsible = contactIdentifier;
        }
    }
}
