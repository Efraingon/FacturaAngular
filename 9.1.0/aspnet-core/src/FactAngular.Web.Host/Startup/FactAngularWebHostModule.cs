using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FactAngular.Configuration;

namespace FactAngular.Web.Host.Startup
{
    [DependsOn(
       typeof(FactAngularWebCoreModule))]
    public class FactAngularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FactAngularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FactAngularWebHostModule).GetAssembly());
        }
    }
}
