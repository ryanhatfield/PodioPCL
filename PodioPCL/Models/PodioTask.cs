// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="PodioTask.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class PodioTask.
	/// </summary>
	public class PodioTask
	{
		/// <summary>
		/// Gets or sets the task identifier.
		/// </summary>
		/// <value>The task identifier.</value>
		[JsonProperty("task_id")]
		public string TaskId { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// Gets or sets the group.
		/// </summary>
		/// <value>The group.</value>
		[JsonProperty("group")]
		public object Group { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="PodioTask"/> is private.
		/// </summary>
		/// <value><c>null</c> if [private] contains no value, <c>true</c> if [private]; otherwise, <c>false</c>.</value>
		[JsonProperty("private")]
		public bool? Private { get; set; }

		/// <summary>
		/// Gets or sets the due on.
		/// </summary>
		/// <value>The due on.</value>
		[JsonProperty("due_on")]
		public DateTime? DueOn { get; set; }

		/// <summary>
		/// Gets or sets the due date.
		/// </summary>
		/// <value>The due date.</value>
		[JsonProperty("due_date")]
		public DateTime? DueDate { get; set; }

		/// <summary>
		/// Gets or sets the due time.
		/// </summary>
		/// <value>The due time.</value>
		[JsonProperty("due_time")]
		public TimeSpan? DueTime { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is liked.
		/// </summary>
		/// <value><c>true</c> if this instance is liked; otherwise, <c>false</c>.</value>
		[JsonProperty("is_liked")]
		public bool IsLiked { get; set; }

		/// <summary>
		/// Gets or sets the like count.
		/// </summary>
		/// <value>The like count.</value>
		[JsonProperty("like_count")]
		public int LikeCount { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="PodioTask"/> is pinned.
		/// </summary>
		/// <value><c>true</c> if pinned; otherwise, <c>false</c>.</value>
		[JsonProperty("pinned")]
		public bool Pinned { get; set; }

		/// <summary>
		/// Gets or sets the presence.
		/// </summary>
		/// <value>The presence.</value>
		[JsonProperty("presence")]
		public Presence Presence { get; set; }

		/// <summary>
		/// Gets or sets the push.
		/// </summary>
		/// <value>The push.</value>
		[JsonProperty("push")]
		public Push Push { get; set; }

		/// <summary>
		/// Gets or sets the space identifier.
		/// </summary>
		/// <value>The space identifier.</value>
		[JsonProperty("space_id")]
		public int? SpaceId { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
		[JsonProperty("link")]
		public string link { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
		[JsonProperty("created_on")]
		public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the completed on.
		/// </summary>
		/// <value>The completed on.</value>
		[JsonProperty("completed_on")]
		public DateTime? CompletedOn { get; set; }

		/// <summary>
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
		[JsonProperty("external_id")]
		public string ExternalId { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
		[JsonProperty("ref")]
		public Reference Reference { get; set; }

		/// <summary>
		/// Gets or sets the created_by.
		/// </summary>
		/// <value>The created_by.</value>
		[JsonProperty("created_by")]
		public ByLine created_by { get; set; }

		/// <summary>
		/// Gets or sets the completed by.
		/// </summary>
		/// <value>The completed by.</value>
		[JsonProperty("completed_by")]
		public ByLine CompletedBy { get; set; }

		/// <summary>
		/// Gets or sets the created via.
		/// </summary>
		/// <value>The created via.</value>
		[JsonProperty("created_via")]
		public Via CreatedVia { get; set; }

		/// <summary>
		/// Gets or sets the deleted via.
		/// </summary>
		/// <value>The deleted via.</value>
		[JsonProperty("deleted_via")]
		public Via DeletedVia { get; set; }

		/// <summary>
		/// Gets or sets the completed via.
		/// </summary>
		/// <value>The completed via.</value>
		[JsonProperty("completed_via")]
		public Via CompletedVia { get; set; }

		/// <summary>
		/// Gets or sets the responsible.
		/// </summary>
		/// <value>The responsible.</value>
		[JsonProperty("responsible")]
		public User Responsible { get; set; }

		/// <summary>
		/// Gets or sets the reminder.
		/// </summary>
		/// <value>The reminder.</value>
		[JsonProperty("reminder")]
		public Reminder Reminder { get; set; }

		/// <summary>
		/// Gets or sets the recurrence.
		/// </summary>
		/// <value>The recurrence.</value>
		[JsonProperty("recurrence")]
		public Recurrence Recurrence { get; set; }

		/// <summary>
		/// Gets or sets the labels.
		/// </summary>
		/// <value>The labels.</value>
		[JsonProperty("labels")]
		public List<PodioTaskLabel> Labels { get; set; }

		/// <summary>
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
		[JsonProperty("files")]
		public List<FileAttachment> Files { get; set; }

		/// <summary>
		/// Gets or sets the comments.
		/// </summary>
		/// <value>The comments.</value>
		[JsonProperty("comments")]
		public List<Comment> Comments { get; set; }
	}
}
