
namespace PodioPCL.Utils.Authentication
{
	/// <summary>
	/// Interface IAuthStore
	/// </summary>
	/// <example>
	/// public class SessionAuthStore : IAuthStore
	/// {
	/// 	public PodioOAuth Get()
	///		{
	/// 		if (HttpContext.Current.Session != null &amp;&amp; HttpContext.Current.Session["PodioOAuth"] != null)
	/// 			return HttpContext.Current.Session["PodioOAuth"] as PodioOAuth;
	/// 		else
	/// 			return new PodioOAuth();
	/// 	}
	///
	/// 	public void Set(PodioOAuth podioOAuth)
	/// 	{
	/// 		HttpContext.Current.Session["PodioOAuth"] = podioOAuth;
	/// 	}
	///	}
	/// </example>
    public interface IAuthStore
    {
		/// <summary>
		/// Get PodioOAuth object from store
		/// </summary>
		/// <returns>PodioOAuth.</returns>
        PodioOAuth Get();

		/// <summary>
		/// Store PodioOAuth object to store
		/// </summary>
		/// <param name="podioOAuth">The podio o authentication.</param>
        void Set(PodioOAuth podioOAuth);
    }
}
