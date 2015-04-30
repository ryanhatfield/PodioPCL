using Microsoft.VisualStudio.TestTools.UnitTesting;
using PodioPCL.Exceptions;
using PodioPCL.Models;
using PodioPCL.Models.ItemFields;
using PodioPCL.Utils.ApplicationFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodioPCL.Tests.Services
{
	[TestClass]
	public class ItemServiceTests
	{
		[TestMethod]
		public async Task CreateItem()
		{
			Podio podio = await TestUtility.GetPodioAndUserLogin();
			var allOrganizations = await podio.OrganizationService.GetOrganizations();
			var organization = allOrganizations.FirstOrDefault();
			var space = organization.Spaces.Where(s => s.Name == "PodioPCL Tests").FirstOrDefault();

			var apps = await podio.ApplicationService.GetAppsBySpace(space.SpaceId);
			var app = apps.Where(a => a.AppId == 10568817).FirstOrDefault();

			Item item = new Item();
			item.Fields.Add(new TextItemField { ExternalId = "sample-text-field-description", Text = "hello world" });
			var id = await podio.ItemService.AddNewItem(app.AppId, item);
			Assert.IsNotNull(item);
		}
	}
}
