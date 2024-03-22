using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FactAngular.EntityFrameworkCore;
using FactAngular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FactAngular.Web.Tests
{
    [DependsOn(
        typeof(FactAngularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FactAngularWebTestModule : AbpModule
    {
        public FactAngularWebTestModule(FactAngularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FactAngularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FactAngularWebMvcModule).Assembly);
        }
    }
}