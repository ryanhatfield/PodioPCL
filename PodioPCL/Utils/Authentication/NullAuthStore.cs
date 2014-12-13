
namespace PodioPCL.Utils.Authentication
{
	/// <summary>
	/// Class NullAuthStore.
	/// </summary>
    public class NullAuthStore : IAuthStore
    {
		/// <summary>
		/// Get PodioOAuth object from store
		/// </summary>
		/// <returns>PodioOAuth.</returns>
        public PodioOAuth Get()
        {
            return new PodioOAuth();
        }

		/// <summary>
		/// Store PodioOAuth object to store
		/// </summary>
		/// <param name="podioOAuth">The podio o authentication.</param>
        public void Set(PodioOAuth podioOAuth)
        {
            
        }

		/// <summary>
		/// Clears this instance.
		/// </summary>
        public void Clear()
        {
            
        }
    }
}
