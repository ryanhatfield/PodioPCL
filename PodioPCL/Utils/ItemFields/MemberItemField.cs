using Newtonsoft.Json.Linq;
using PodioPCL.Models;
using System.Collections.Generic;

namespace PodioPCL.Utils.ItemFields
{
	public class MemberItemField : ItemField
	{
		private List<User> _users;

		public IEnumerable<User> Users
		{
			get
			{
				return this.valuesAs<User>(_users);
			}
		}

		/// <summary>
		/// The profile_id's of the contacts
		/// </summary>
		public IEnumerable<int> UserIds
		{
			set
			{
				ensureValuesInitialized();
				foreach (var userId in value)
				{
					var jobject = new JObject();
					jobject["value"] = userId;
					this.Values.Add(jobject);
				}
			}
		}

		public int UserId
		{
			set
			{
				ensureValuesInitialized();

				var jobject = new JObject();
				jobject["value"] = value;
				this.Values.Add(jobject);

			}
		}

	}
}
