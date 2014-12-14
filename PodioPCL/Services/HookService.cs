using PodioPCL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PodioPCL.Services
{
	/// <summary>
	/// Class HookService.
	/// </summary>
	public class HookService
	{
		private Podio _podio;
		/// <summary>
		/// Initializes a new instance of the <see cref="HookService"/> class.
		/// </summary>
		/// <param name="currentInstance">The current instance.</param>
		public HookService(Podio currentInstance)
		{
			_podio = currentInstance;
		}

		/// <summary>
		/// Create a new hook on the given object. See the area for details.
		/// <para>Podio API Reference: https://developers.podio.com/doc/hooks/create-hook-215056 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <param name="externalURL">The url of endpoint.</param>
		/// <param name="type">The type of events to listen to, see the area for options.</param>
		/// <returns>Task&lt;System.Int32&gt;.</returns>
		public async Task<int> CreateHook(string refType, int refId, string externalURL, string type)
		{
			string url = string.Format("/hook/{0}/{1}/", refType, refId);
			dynamic requestData = new
			{
				url = externalURL,
				type = type
			};
			dynamic response = await _podio.PostAsync<dynamic>(url, requestData);
			return (int)response["hook_id"];
		}

		/// <summary>
		/// Deletes the hook with the given id.
		/// <para>Podio API Reference: https://developers.podio.com/doc/hooks/delete-hook-215291 </para>
		/// </summary>
		/// <param name="hookId"></param>
		public Task DeleteHook(int hookId)
		{
			string url = string.Format("/hook/{0}", hookId);
			return _podio.DeleteAsync<dynamic>(url);
		}

		/// <summary>
		/// Returns the hooks on the object.
		/// <para>Podio API Reference: https://developers.podio.com/doc/hooks/get-hooks-215285 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <returns>Task&lt;List&lt;Hook&gt;&gt;.</returns>
		public Task<List<Hook>> GetHooks(string refType, int refId)
		{
			string url = string.Format("/hook/{0}/{1}/", refType, refId);
			return _podio.GetAsync<List<Hook>>(url);
		}

		/// <summary>
		/// Request the hook to be validated. This will cause the hook to send a request to the URL with the parameter "type" set to "hook.verify" and "code" set to the verification code. The endpoint must then call the validate method with the code to complete the verification.
		/// <para>Podio API Reference: https://developers.podio.com/doc/hooks/request-hook-verification-215232 </para>
		/// </summary>
		/// <param name="hookId">The hook identifier.</param>
		/// <returns>Task.</returns>
		public Task Verify(int hookId)
		{
			string url = string.Format("/hook/{0}/verify/request", hookId);
			return _podio.PostAsync<dynamic>(url);
		}

		/// <summary>
		/// Validates the hook using the code received from the verify call. On successful validation the hook will become active.
		/// <para>Podio API Reference: https://developers.podio.com/doc/hooks/validate-hook-verification-215241 </para>
		/// </summary>
		/// <param name="hookId">The hook identifier.</param>
		/// <param name="code">The code.</param>
		/// <returns>Task.</returns>
		public Task ValidateHookVerification(int hookId, string code)
		{
			string url = string.Format("/hook/{0}/verify/validate", hookId);
			dynamic requestData = new
			{
				code = code
			};
			return _podio.PostAsync<dynamic>(url, requestData);
		}

	}
}
