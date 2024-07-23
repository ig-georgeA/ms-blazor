using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TeamCollaboration.Pages.Master_View;
using TeamCollaboration.FinTech_API;

namespace TestTeamCollaboration
{
	[Collection("TeamCollaboration")]
	public class TestChild_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbFinancialChartModule));
			ctx.Services.AddScoped<IFinTech_APIService>(sp => new MockFinTech_APIService());
			var componentUnderTest = ctx.RenderComponent<Child_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
