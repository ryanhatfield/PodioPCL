using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PodioPCL.Utils;
using PodioPCL.Models;
using PodioPCL.Utils.Authentication;

namespace PodioPCL.Tests
{
	[TestClass]
	public class PodioAuthenticationTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Podio _Podio;
			StaticAuthStore _AuthStore;

			_AuthStore = new StaticAuthStore();
			_Podio = new Podio(Settings.ClientId, Settings.ClientSecret, _AuthStore);
			_Podio.AuthenticateWithApp(Settings.AppId, Settings.AppToken);

			var moments = _Podio.ItemService.FilterItems(Settings.AppId);

			Assert.IsNotNull(moments);
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
