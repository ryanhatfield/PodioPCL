using System.Collections.Generic;
using PodioPCL.Models;
using System.Dynamic;
using System.Threading.Tasks;

namespace PodioPCL.Services
{
	/// <summary>
	/// Class StatusService.
	/// </summary>
    public class StatusService
    {
        private Podio _podio;
		/// <summary>
		/// Initializes a new instance of the <see cref="StatusService"/> class.
		/// </summary>
		/// <param name="currentInstance">The current instance.</param>
        public StatusService(Podio currentInstance)
        {
            _podio = currentInstance;
        }

		/// <summary>
		/// Retrieves a status message by its id.
		/// <para>Podio API Reference: https://developers.podio.com/doc/status/get-status-message-22337 </para>
		/// </summary>
		/// <param name="statusId">The status identifier.</param>
		/// <returns>Task&lt;Status&gt;.</returns>
        public Task<Status> GetStatusMessage(int statusId)
        {
            string url = string.Format("/status/{0}", statusId);
            return _podio.GetAsync<Status>(url);
        }

		/// <summary>
		/// Creates a new status message for a user on a specific space.
		/// <para>Podio API Reference: https://developers.podio.com/doc/status/add-new-status-message-22336 </para>
		/// </summary>
		/// <param name="spaceId">The space identifier.</param>
		/// <param name="text">The actual status message</param>
		/// <param name="fileIds">Temporary files that have been uploaded and should be attached to this item</param>
		/// <param name="embedId">The id of an embedded link that has been created with the Add an mebed operation in the Embed area</param>
		/// <param name="embedUrl">The url to be attached</param>
		/// <param name="questionText">The text of the question if any</param>
		/// <param name="questionOptions">The list of answer options as strings</param>
		/// <returns>Task&lt;Status&gt;.</returns>
        public Task<Status> AddNewStatusMessage(int spaceId, string text, List<int> fileIds = null, int? embedId = null, string embedUrl = null, string questionText = null, List<string> questionOptions = null)
        {
            string url = string.Format("/status/space/{0}/",spaceId);

            dynamic requestData = new ExpandoObject();
            requestData.value = text;
            requestData.file_ids = fileIds;
            requestData.embed_id = embedId;
            requestData.embedUrl = embedUrl;
            if (!string.IsNullOrEmpty(questionText) && questionOptions != null)
            {
                requestData.question = new
                {
                    text = questionText,
                    options = questionOptions
                };
            }

            return _podio.PostAsync<Status>(url, requestData);
        }

		/// <summary>
		/// This will update an existing status message.
		/// <para>Podio API Reference: https://developers.podio.com/doc/status/update-a-status-message-22338 </para>
		/// </summary>
		/// <param name="statusId">The status identifier.</param>
		/// <param name="text">The actual status message</param>
		/// <param name="fileIds">Temporary files that have been uploaded and should be attached to this item</param>
		/// <param name="embedId">The id of an embedded link that has been created with the Add an mebed operation in the Embed area</param>
		/// <param name="embedUrl">The url to be attached</param>
		/// <returns>Task.</returns>
        public Task UpdateStatusMessage(int statusId, string text, List<int> fileIds = null, int? embedId = null, string embedUrl = null)
        {
            string url = string.Format("/status/{0}", statusId);
            dynamic requestData = new
            {
                value = text,
                file_ids = fileIds,
                embed_id = embedId,
                embed_url = embedUrl
            };
            return _podio.PutAsync<dynamic>(url, requestData);
        }

		/// <summary>
		/// This is used to delete a status message
		/// <para>Podio API Reference: https://developers.podio.com/doc/status/delete-a-status-message-22339 </para>
		/// </summary>
		/// <param name="statusId">The status identifier.</param>
		/// <returns>Task.</returns>
        public Task DeleteStatusMessage(int statusId)
        {
            string url = string.Format("/status/{0}", statusId);
            return _podio.DeleteAsync<dynamic>(url);
        }
    }
}
