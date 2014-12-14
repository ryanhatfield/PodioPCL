using PodioPCL.Models;
using System.Threading.Tasks;

namespace PodioPCL.Services
{
	/// <summary>
	/// Class SubscriptionService.
	/// </summary>
    public class SubscriptionService
    {
        private Podio _podio;
		/// <summary>
		/// Initializes a new instance of the <see cref="SubscriptionService"/> class.
		/// </summary>
		/// <param name="currentInstance">The current instance.</param>
        public SubscriptionService(Podio currentInstance)
        {
            _podio = currentInstance;
        }

		/// <summary>
		/// Returns the subscription with the given id.
		/// <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/get-subscription-by-id-22446 </para>
		/// </summary>
		/// <param name="subscriptionId">The subscription identifier.</param>
		/// <returns>Task&lt;Subscription&gt;.</returns>
        public Task<Subscription> GetSubscriptionById(int subscriptionId)
        {
            string url = string.Format("/subscription/{0}", subscriptionId);
            return _podio.GetAsync<Subscription>(url);
        }

		/// <summary>
		/// Subscribes the user to the given object. Based on the object type, the user will receive notifications when actions are performed on the object. See the area for more details.
		/// <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/subscribe-22409 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <returns>Task&lt;System.Int32&gt;.</returns>
        public async Task<int> Subscribe(string refType, int refId)
        {
            string url = string.Format("/subscription/{0}/{1}", refType, refId);
            dynamic response = await _podio.PostAsync<dynamic>(url);
            return (int)response["subscription_id"];
        }

		/// <summary>
		/// Unsubscribe from getting notifications on actions on the given object.
		/// <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/unsubscribe-by-reference-22410 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <returns>Task.</returns>
        public Task UnsubscribeByReference(string refType, int refId)
        {
            string url = string.Format("/subscription/{0}/{1}", refType,refId);
            return _podio.DeleteAsync<dynamic>(url);
        }

		/// <summary>
		/// Get the subscription for the given object.
		/// <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/get-subscription-by-reference-22408 </para>
		/// </summary>
		/// <param name="refType">Type of the reference.</param>
		/// <param name="refId">The reference identifier.</param>
		/// <returns>Task&lt;Subscription&gt;.</returns>
        public Task<Subscription> GetSubscriptionByReference(string refType, int refId)
        {
            string url = string.Format("/subscription/{0}/{1}", refType, refId);
            return _podio.GetAsync<Subscription>(url);
        }

		/// <summary>
		/// Stops the subscription with the given id
		/// <para>Podio API Reference: https://developers.podio.com/doc/subscriptions/unsubscribe-by-id-22445 </para>
		/// </summary>
		/// <param name="subscriptionId">The subscription identifier.</param>
		/// <returns>Task.</returns>
        public Task UnsubscribeById(int subscriptionId)
        {
            string url = string.Format("/subscription/{0}", subscriptionId);
            return _podio.DeleteAsync<dynamic>(url);
        }
    }
}
