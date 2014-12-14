using PodioPCL.Models;
using System.Threading.Tasks;

namespace PodioPCL.Services
{
	/// <summary>
	/// Class RecurrenceService.
	/// </summary>
    public class RecurrenceService
    {
        private Podio _podio;
		/// <summary>
		/// Initializes a new instance of the <see cref="RecurrenceService"/> class.
		/// </summary>
		/// <param name="currentInstance">The current instance.</param>
        public RecurrenceService(Podio currentInstance)
        {
            _podio = currentInstance;
        }

		/// <summary>
		/// Returns the recurrence for the given object
		/// <para>Podio API Reference: https://developers.podio.com/doc/recurrence/get-recurrence-3415545 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <returns>Task&lt;Recurrence&gt;.</returns>
        public Task<Recurrence> GetRecurrence(string refType, int refId)
        {
            string url = string.Format("/recurrence/{0}/{1}", refType, refId);
            return _podio.GetAsync<Recurrence>(url);
        }

		/// <summary>
		/// Deletes the recurrence.
		/// <para>Podio API Reference: https://developers.podio.com/doc/recurrence/delete-recurrence-3349970 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <returns>Task.</returns>
        public Task DeleteRecurrence(string refType, int refId)
        {
            string url = string.Format("/recurrence/{0}/{1}", refType, refId);
            return _podio.DeleteAsync<dynamic>(url);
        }

		/// <summary>
		/// Creates or updates recurrence on the object.
		/// <para>Podio API Reference: https://developers.podio.com/doc/recurrence/create-or-update-recurrence-3349957 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <param name="recurrence">The recurrence.</param>
		/// <returns>Task.</returns>
        public Task UpdateRecurrence(string refType, int refId, Recurrence recurrence)
        {
            string url = string.Format("/recurrence/{0}/{1}", refType, refId);
            return _podio.PutAsync<dynamic>(url, recurrence);
        }
    }
}
