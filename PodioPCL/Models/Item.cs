// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-13-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Item.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using PodioPCL.Utils;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Item.
	/// </summary>
	public class Item
	{
		/// <summary>
		/// Gets or sets the item identifier.
		/// </summary>
		/// <value>The item identifier.</value>
		[JsonProperty("item_id")]
		public int ItemId { get; set; }

		/// <summary>
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
		[JsonProperty("external_id")]
		public string ExternalId { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
		[JsonProperty("link")]
		public string Link { get; set; }

		/// <summary>
		/// Gets or sets the rights.
		/// </summary>
		/// <value>The rights.</value>
		[JsonProperty("rights")]
		public string[] Rights { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
		[JsonProperty("created_on")]
		public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the application item identifier formatted.
		/// </summary>
		/// <value>The application item identifier formatted.</value>
		[JsonProperty("app_item_id_formatted")]
		public string AppItemIdFormatted { get; set; }

		/// <summary>
		/// Gets or sets the application item identifier.
		/// </summary>
		/// <value>The application item identifier.</value>
		[JsonProperty("app_item_id")]
		public int? AppItemId { get; set; }


		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
		[JsonProperty("created_by")]
		public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the created via.
		/// </summary>
		/// <value>The created via.</value>
		[JsonProperty("created_via")]
		public Via CreatedVia { get; set; }

		/// <summary>
		/// Gets or sets the initial revision.
		/// </summary>
		/// <value>The initial revision.</value>
		[JsonProperty("initial_revision")]
		public ItemRevision InitialRevision { get; set; }

		/// <summary>
		/// Gets or sets the current revision.
		/// </summary>
		/// <value>The current revision.</value>
		[JsonProperty("current_revision")]
		public ItemRevision CurrentRevision { get; set; }

		/// <summary>
		/// Gets or sets the fields.
		/// </summary>
		/// <value>The fields.</value>
		[JsonProperty("fields")]
		public List<ItemField> Fields { get; set; }


		//Extra properties for full item
		/// <summary>
		/// Gets or sets the ratings.
		/// </summary>
		/// <value>The ratings.</value>
		[JsonProperty("ratings")]
		public Dictionary<string, object> Ratings { get; set; }

		/// <summary>
		/// Gets or sets the user ratings.
		/// </summary>
		/// <value>The user ratings.</value>
		[JsonProperty("user_ratings")]
		public Dictionary<string, object> UserRatings { get; set; }

		/// <summary>
		/// Gets or sets the last event on.
		/// </summary>
		/// <value>The last event on.</value>
		[JsonProperty("last_event_on")]
		public DateTime? LastEventOn { get; set; }

		/// <summary>
		/// Gets or sets the participants.
		/// </summary>
		/// <value>The participants.</value>
		[JsonProperty("participants")]
		public JObject Participants { get; set; }

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		/// <value>The tags.</value>
		[JsonProperty("tags")]
		public List<string> Tags { get; set; }

		/// <summary>
		/// Gets or sets the refs.
		/// </summary>
		/// <value>The refs.</value>
		[JsonProperty("refs")]
		public JArray Refs { get; set; }

		/// <summary>
		/// Gets or sets the references.
		/// </summary>
		/// <value>The references.</value>
		[JsonProperty("references")]
		public JArray References { get; set; }

		/// <summary>
		/// Gets or sets the linked account identifier.
		/// </summary>
		/// <value>The linked account identifier.</value>
		[JsonProperty("linked_account_id")]
		public int? LinkedAccountId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Item"/> is subscribed.
		/// </summary>
		/// <value><c>null</c> if [subscribed] contains no value, <c>true</c> if [subscribed]; otherwise, <c>false</c>.</value>
		[JsonProperty("subscribed")]
		public bool? Subscribed { get; set; }

		/// <summary>
		/// Gets or sets the invite.
		/// </summary>
		/// <value>The invite.</value>
		[JsonProperty("invite")]
		public JToken Invite { get; set; }

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
		/// Gets or sets the application.
		/// </summary>
		/// <value>The application.</value>
		[JsonProperty("app")]
		public Application App { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
		[JsonProperty("ref")]
		public Reference Ref { get; set; }

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
		/// Gets or sets the linked account data.
		/// </summary>
		/// <value>The linked account data.</value>
		[JsonProperty("linked_account_data")]
		public LinkedAccountData LinkedAccountData { get; set; }

		/// <summary>
		/// Gets or sets the comments.
		/// </summary>
		/// <value>The comments.</value>
		[JsonProperty("comments")]
		public List<Comment> Comments { get; set; }

		/// <summary>
		/// Gets or sets the revisions.
		/// </summary>
		/// <value>The revisions.</value>
		[JsonProperty("revisions")]
		public List<ItemRevision> Revisions { get; set; }

		/// <summary>
		/// Gets or sets the files.
		/// </summary>
		/// <value>The files.</value>
		[JsonProperty("files")]
		public List<FileAttachment> Files { get; set; }

		/// <summary>
		/// Gets or sets the grant.
		/// </summary>
		/// <value>The grant.</value>
		[JsonProperty("grant")]
		public Grant Grant { get; set; }

		/// <summary>
		/// Gets or sets the file ids.
		/// </summary>
		/// <value>The file ids.</value>
		[JsonProperty("file_ids")]
		public List<int> FileIds { get; set; }

		/// <summary>
		/// Gets or sets the tasks.
		/// </summary>
		/// <value>The tasks.</value>
		[JsonProperty("tasks")]
		public List<PodioTask> Tasks { get; set; }

		/// <summary>
		/// Gets or sets the shares.
		/// </summary>
		/// <value>The shares.</value>
		[JsonProperty("shares")]
		public List<AppMarketShare> Shares { get; set; }

		//When getting item collection
		/// <summary>
		/// Gets or sets the comment count.
		/// </summary>
		/// <value>The comment count.</value>
		[JsonProperty("comment_count")]
		public int CommentCount { get; set; }

		/// <summary>
		/// Gets or sets the task count.
		/// </summary>
		/// <value>The task count.</value>
		[JsonProperty("task_count")]
		public int TaskCount { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Item"/> class.
		/// </summary>
		public Item()
		{
			this.Fields = new List<ItemField>();
		}

		/// <summary>
		/// Fields the specified external identifier.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="externalId">The external identifier.</param>
		/// <returns>T.</returns>
		public T Field<T>(string externalId)
			where T : ItemField, new()
		{
			var genericField = this.Fields.Find(field => field.ExternalId == externalId);
			return fieldInstance<T>(genericField, externalId);
		}

		/// <summary>
		/// Fields the specified field identifier.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="fieldId">The field identifier.</param>
		/// <returns>T.</returns>
		public T Field<T>(int fieldId)
			where T : ItemField, new()
		{
			var genericField = this.Fields.Find(field => field.FieldId == fieldId);
			return fieldInstance<T>(genericField, null, fieldId);
		}

		/// <summary>
		/// Fields the instance.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="genericField">The generic field.</param>
		/// <param name="externalId">The external identifier.</param>
		/// <param name="fieldId">The field identifier.</param>
		/// <returns>T.</returns>
		protected T fieldInstance<T>(ItemField genericField, string externalId = null, int? fieldId = null)
					where T : ItemField, new()
		{
			T specificField = new T();
			if (genericField != null)
			{
				foreach (var property in genericField.GetType().GetRuntimeProperties())
				{
					var jsonAttribute = ((JsonPropertyAttribute[])property.GetCustomAttributes(typeof(JsonPropertyAttribute), false));
					if (jsonAttribute.Length > 0)
						specificField.GetType().GetRuntimeProperty(property.Name).SetValue(specificField, property.GetValue(genericField, null), null);
				}
			}
			else
			{
				specificField.ExternalId = externalId;
				specificField.FieldId = fieldId;
				this.Fields.Add(specificField);
			}
			return specificField;
		}
	}
}
