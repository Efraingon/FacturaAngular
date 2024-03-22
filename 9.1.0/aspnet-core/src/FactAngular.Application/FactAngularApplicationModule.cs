using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FactAngular.Authorization;

namespace FactAngular
{
    [DependsOn(
        typeof(FactAngularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FactAngularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FactAngularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FactAngularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
