namespace PodioPCL.Utils.Authentication
{
	/// <summary>
	/// Class StaticAuthStore.
	/// </summary>
	public class StaticAuthStore : IAuthStore
	{
		private static PodioOAuth _StaticAuth;

		/// <summary>
		/// Get PodioOAuth object from store
		/// </summary>
		/// <returns>PodioOAuth.</returns>
		public PodioOAuth Get()
		{
			if (_StaticAuth != null)
				return _StaticAuth;
			else
				return new PodioOAuth();
		}

		/// <summary>
		/// Store PodioOAuth object to store
		/// </summary>
		/// <param name="podioOAuth">The podio o authentication.</param>
		public void Set(PodioOAuth podioOAuth)
		{
			_StaticAuth = podioOAuth;
		}
	}
}
