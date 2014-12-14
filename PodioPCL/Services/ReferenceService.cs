using System.Collections.Generic;
using PodioPCL.Models;
using PodioPCL.Utils;
using PodioPCL.Models.Request;
using System.Threading.Tasks;

namespace PodioPCL.Services
{
	/// <summary>
	/// Class ReferenceService.
	/// </summary>
	public class ReferenceService
	{
		private Podio _podio;
		/// <summary>
		/// Initializes a new instance of the <see cref="ReferenceService"/> class.
		/// </summary>
		/// <param name="currentInstance">The current instance.</param>
		public ReferenceService(Podio currentInstance)
		{
			_podio = currentInstance;
		}

		/// <summary>
		/// Returns the number of other users with access to the given object.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reference/count-user-profiles-with-access-to-object-19190550 </para>
		/// </summary>
		/// <param name="refType"></param>
		/// <param name="refId"></param>
		/// <returns></returns>
		public async Task<int> CountUserWithAccess(string refType, int refId)
		{
			string url = string.Format("/reference/{0}/{1}/accessible_by/count", refType, refId);
			dynamic response = await _podio.GetAsync<dynamic>(url);
			return (int)response["count"];
		}

		/// <summary>
		/// Returns user profiles who have access to an object, either because they have been explicitly granted access to it or because they are members of the object's workspace.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reference/get-user-profiles-with-access-to-object-16681010 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <param name="limit">The maximum number of profiles to return for each access type</param>
		/// <param name="offset">The offset into the profiles to return</param>
		/// <returns>Task&lt;List&lt;Contact&gt;&gt;.</returns>
		public Task<List<Contact>> FindUserWithAccess(string refType, int refId, int? limit = null, int? offset = null)
		{
			string url = string.Format("/reference/{0}/{1}/accessible_by/", refType, refId);
			var requestData = new Dictionary<string, string>()
            {
                {"limit",limit.ToStringOrNull()},
                {"offset",offset.ToStringOrNull()}
            };
			return _podio.GetAsync<List<Contact>>(url, requestData);
		}

		/// <summary>
		/// Returns information about the reference.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reference/get-reference-10661022 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <param name="accessorCount">If true, the response will include an "accessor_count" property, the number of users that have access to this object. Default value: false</param>
		/// <param name="contextId">The id of the context to check the reference against.</param>
		/// <param name="contextType">The context type to check the reference against. Currently only supports "app".</param>
		/// <returns>Task&lt;Reference&gt;.</returns>
		public Task<Reference> GetReference(string refType, int refId, bool accessorCount = false, int? contextId = null, string contextType = null)
		{
			string url = string.Format("/reference/{0}/{1}", refType, refId);
			var requestData = new Dictionary<string, string>()
            {
                {"accessor_count",accessorCount.ToStringOrNull()},
                {"context_id",contextId.ToStringOrNull()},
                {"context_type",contextType}
            };
			return _podio.GetAsync<Reference>(url, requestData);
		}

		/// <summary>
		/// Resolves the url given in the parameter to a reference. If the URL could not be resolved, status code 404 will be returned. If the user does not have access to the URL, status code 403 will be returned.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reference/resolve-url-66839423 </para>
		/// </summary>
		/// <param name="referenceUrl">Currently supported URL's are: App market app/pack, App, File permalink, Item permalink, Space, Status permalink, Task permalink, User profile</param>
		/// <returns>Task&lt;Reference&gt;.</returns>
		public Task<Reference> ResolveURL(string referenceUrl)
		{
			string url = "/reference/resolve";
			var requestData = new Dictionary<string, string>()
            {
                {"url",referenceUrl}
            };
			return _podio.GetAsync<Reference>(url, requestData);
		}

		/// <summary>
		/// Search for references for use in various contexts.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reference/search-references-13312595 </para>
		/// </summary>
		/// <param name="searchReferenceRequest">The search reference request.</param>
		/// <returns>Task&lt;List&lt;ReferenceGroup&gt;&gt;.</returns>
		public Task<List<ReferenceGroup>> SearchReferences(SearchReferencesRequest searchReferenceRequest)
		{
			string url = "/reference/search";
			return _podio.PostAsync<List<ReferenceGroup>>(url, searchReferenceRequest);
		}
	}
}
