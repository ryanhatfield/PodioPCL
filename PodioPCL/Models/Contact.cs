// ***********************************************************************
// Assembly         : PodioPCL
// Author           : OnsharpRyan
// Created          : 12-09-2014
//
// Last Modified By : OnsharpRyan
// Last Modified On : 12-13-2014
// ***********************************************************************
// <copyright file="Contact.cs" company="Onsharp">
//     Copyright (c) Onsharp. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Contact.
	/// </summary>
    public class Contact
    {
		/// <summary>
		/// Gets or sets the profile identifier.
		/// </summary>
		/// <value>The profile identifier.</value>
        [JsonProperty("profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public int ProfileId { get; set; }

		/// <summary>
		/// Gets or sets the user identifier.
		/// </summary>
		/// <value>The user identifier.</value>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; }

		/// <summary>
		/// Gets or sets the external identifier.
		/// </summary>
		/// <value>The external identifier.</value>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

		/// <summary>
		/// The file id of the avatar
		/// </summary>
		/// <value>The avatar.</value>
        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public int Avatar { get; set; }

		/// <summary>
		/// Gets or sets the birth date.
		/// </summary>
		/// <value>The birth date.</value>
        public DateTime? BirthDate {
            get
            {
                if (!string.IsNullOrEmpty(BirthDateString))
                    return DateTime.ParseExact(BirthDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                return null;
            }
            set 
            { 
                BirthDateString = value.Value.ToString("yyyy-MM-dd"); 
            } 
        }

		/// <summary>
		/// Gets or sets the birth date string.
		/// </summary>
		/// <value>The birth date string.</value>
        [JsonProperty("birthdate", NullValueHandling = NullValueHandling.Ignore)]
        internal string BirthDateString { get; set; }

		/// <summary>
		/// Gets or sets the department.
		/// </summary>
		/// <value>The department.</value>
        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public string Department { get; set; }

		/// <summary>
		/// Gets or sets the vatin.
		/// </summary>
		/// <value>The vatin.</value>
        [JsonProperty("vatin", NullValueHandling = NullValueHandling.Ignore)]
        public string Vatin { get; set; }

		/// <summary>
		/// Gets or sets the skype.
		/// </summary>
		/// <value>The skype.</value>
        [JsonProperty("skype", NullValueHandling = NullValueHandling.Ignore)]
        public string Skype { get; set; }

		/// <summary>
		/// Gets or sets the about.
		/// </summary>
		/// <value>The about.</value>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public string About { get; set; }

		/// <summary>
		/// Gets or sets the address.
		/// </summary>
		/// <value>The address.</value>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Address { get; set; }

		/// <summary>
		/// Gets or sets the zip.
		/// </summary>
		/// <value>The zip.</value>
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

		/// <summary>
		/// Gets or sets the im.
		/// </summary>
		/// <value>The im.</value>
        [JsonProperty("im", NullValueHandling = NullValueHandling.Ignore)]
        public String[] IM { get; set; }

		/// <summary>
		/// Gets or sets the location.
		/// </summary>
		/// <value>The location.</value>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Location { get; set; }

		/// <summary>
		/// Gets or sets the mail.
		/// </summary>
		/// <value>The mail.</value>
        [JsonProperty("mail", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Mail { get; set; }

		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Phone { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Title { get; set; }

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Url { get; set; }

		/// <summary>
		/// Gets or sets the skill.
		/// </summary>
		/// <value>The skill.</value>
        [JsonProperty("skill", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Skill { get; set; }

		/// <summary>
		/// Gets or sets the linked in.
		/// </summary>
		/// <value>The linked in.</value>
        [JsonProperty("linkedin", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkedIn { get; set; }

		/// <summary>
		/// Gets or sets the twitter.
		/// </summary>
		/// <value>The twitter.</value>
        [JsonProperty("twitter", NullValueHandling = NullValueHandling.Ignore)]
        public string Twitter { get; set; }

		/// <summary>
		/// Gets or sets the organization.
		/// </summary>
		/// <value>The organization.</value>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

		/// <summary>
		/// Gets or sets the space identifier.
		/// </summary>
		/// <value>The space identifier.</value>
        [JsonProperty("space_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpaceId { get; set; }

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>The link.</value>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

		/// <summary>
		/// Gets or sets the rights.
		/// </summary>
		/// <value>The rights.</value>
        [JsonProperty("rights", NullValueHandling = NullValueHandling.Ignore)]
        public String[] Rights { get; set; }

		/// <summary>
		/// Gets or sets the about application store.
		/// </summary>
		/// <value>The about application store.</value>
        [JsonProperty("app_store_about", NullValueHandling = NullValueHandling.Ignore)]
        public string AboutAppStore { get; set; }

		/// <summary>
		/// Gets or sets the application store organization.
		/// </summary>
		/// <value>The application store organization.</value>
        [JsonProperty("app_store_organization", NullValueHandling = NullValueHandling.Ignore)]
        public string AppStoreOrganization { get; set; }

		/// <summary>
		/// Gets or sets the application store location.
		/// </summary>
		/// <value>The application store location.</value>
        [JsonProperty("app_store_location", NullValueHandling = NullValueHandling.Ignore)]
        public string AppStoreLocation { get; set; }

		/// <summary>
		/// Gets or sets the application store title.
		/// </summary>
		/// <value>The application store title.</value>
        [JsonProperty("app_store_title", NullValueHandling = NullValueHandling.Ignore)]
        public string AppStoreTitle { get; set; }

		/// <summary>
		/// Gets or sets the application store URL.
		/// </summary>
		/// <value>The application store URL.</value>
        [JsonProperty("app_store_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppStoreUrl { get; set; }

		/// <summary>
		/// Gets or sets the last seen on.
		/// </summary>
		/// <value>The last seen on.</value>
        [JsonProperty("last_seen_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastSeenOn { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is employee.
		/// </summary>
		/// <value><c>null</c> if [is employee] contains no value, <c>true</c> if [is employee]; otherwise, <c>false</c>.</value>
        [JsonProperty("is_employee", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEmployee { get; set; }

        // Only available for space contacts

		/// <summary>
		/// Gets or sets the role.
		/// </summary>
		/// <value>The role.</value>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public int? Role { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Contact"/> is removable.
		/// </summary>
		/// <value><c>null</c> if [removable] contains no value, <c>true</c> if [removable]; otherwise, <c>false</c>.</value>
        [JsonProperty("removable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Removable { get; set; }

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>The image.</value>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public FileAttachment Image { get; set; }
       
    }
}
