using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PodioPCL.Utils.Authentication;
using System.Threading.Tasks;

namespace PodioPCL.Tests
{
	[TestClass]
	public class PodioAuthenticationTests
	{
		[TestMethod]
		public async Task TestMethod1()
		{
			Podio _Podio;
			StaticAuthStore _AuthStore;

			_AuthStore = new StaticAuthStore();
			_Podio = new Podio(Settings.ClientId, Settings.ClientSecret, _AuthStore);
			await _Podio.AuthenticateWithApp(Settings.AppId, Settings.AppToken);

			var items = await _Podio.ItemService.FilterItems(Settings.AppId);

			Assert.IsNotNull(items);
		}


		public static class Settings
		{
			public static readonly string ClientId = "";
			public static readonly string ClientSecret = "";

			public static readonly int AppId = 0;
			public static readonly string AppToken = "";
		}
	}
}
