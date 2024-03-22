using System.Threading.Tasks;
using FactAngular.Models.TokenAuth;
using FactAngular.Web.Controllers;
using Shouldly;
using Xunit;

namespace FactAngular.Web.Tests.Controllers
{
    public class HomeController_Tests: FactAngularWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}