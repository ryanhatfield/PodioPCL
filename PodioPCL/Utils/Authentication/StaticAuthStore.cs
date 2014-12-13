using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodioPCL.Utils.Authentication
{
	public class StaticAuthStore : IAuthStore
	{
		private static PodioOAuth _StaticAuth;

		public PodioOAuth Get()
		{
			if (_StaticAuth != null)
				return _StaticAuth;
			else
				return new PodioOAuth();
		}

		public void Set(PodioOAuth podioOAuth)
		{
			_StaticAuth = podioOAuth;
		}
	}
}
