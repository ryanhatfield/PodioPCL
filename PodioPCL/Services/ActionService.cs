using PodioPCL.Models;
using System.Threading.Tasks;

namespace PodioPCL.Services
{
	/// <summary>
	/// Class ActionService.
	/// </summary>
  public  class ActionService
    {
      private Podio _podio;
	  /// <summary>
	  /// Initializes a new instance of the <see cref="ActionService"/> class.
	  /// </summary>
	  /// <param name="currentInstance">The current instance.</param>
      public ActionService(Podio currentInstance)
      {
          _podio = currentInstance;
      }

      /// <summary>
      /// Returns the action with the given id.
      /// <para>Podio API Reference: https://developers.podio.com/doc/actions/get-action-1701120 </para>
      /// </summary>
      /// <param name="actionId"></param>
      /// <returns></returns>
      public Task<Action> GetAction(int actionId)
      {
          string url = string.Format("/action/{0}", actionId);
          return _podio.GetAsync<Action>(url);
      }
    }
}
