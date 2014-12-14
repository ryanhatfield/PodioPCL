
using System.Threading.Tasks;
namespace PodioPCL.Services
{
	/// <summary>
	/// Class ReminderService.
	/// </summary>
	public class ReminderService
	{
		private Podio _podio;
		/// <summary>
		/// Initializes a new instance of the <see cref="ReminderService"/> class.
		/// </summary>
		/// <param name="currentInstance">The current instance.</param>
		public ReminderService(Podio currentInstance)
		{
			_podio = currentInstance;
		}

		/// <summary>
		/// Returns the reminder for the given object.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reminders/get-reminder-3415569 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <returns>Task&lt;System.Int32&gt;.</returns>
		public async Task<int> GetReminder(string refType, int refId)
		{
			string url = string.Format("/reminder/{0}/{1}", refType, refId);
			dynamic response = await _podio.GetAsync<dynamic>(url);
			return (int)response["remind_delta"];
		}

		/// <summary>
		/// Deletes the reminder, if any, on the given object.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reminders/delete-reminder-3315117 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <param name="reminderId">The reminder identifier.</param>
		/// <returns>Task.</returns>
		public Task DeleteReminder(string refType, int refId, int reminderId)
		{
			string url = string.Format("/reminder/{0}/{1}?reminder_id={2}", refType, refId, reminderId);
			return _podio.DeleteAsync<dynamic>(url);
		}

		/// <summary>
		/// Snoozes the reminder for 10 minutes.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reminders/snooze-reminder-3321049 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <param name="reminderId">The reminder identifier.</param>
		/// <returns>Task.</returns>
		public Task SnoozeReminder(string refType, int refId, int reminderId)
		{
			string url = string.Format("/reminder/{0}/{1}/snooze?reminder_id={2}", refType, refId, reminderId);
			return _podio.PostAsync<dynamic>(url);
		}

		/// <summary>
		/// Creates or updates the reminder on a object. Possible ref_types are: task.
		/// <para>Podio API Reference: https://developers.podio.com/doc/reminders/create-or-update-reminder-3315055 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <param name="remindDelta">minutes to remind before the due date of the object</param>
		/// <returns>Task.</returns>
		public Task Update(string refType, int refId, int remindDelta)
		{
			string url = string.Format("/reminder/{0}/{1}", refType, refId);
			dynamic requestData = new
			{
				remind_delta = remindDelta
			};
			return _podio.PutAsync<dynamic>(url, requestData);
		}
	}
}
