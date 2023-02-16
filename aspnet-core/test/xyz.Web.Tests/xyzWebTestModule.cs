using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using xyz.EntityFrameworkCore;
using xyz.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace xyz.Web.Tests
{
    [DependsOn(
        typeof(xyzWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class xyzWebTestModule : AbpModule
    {
        public xyzWebTestModule(xyzEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(xyzWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(xyzWebMvcModule).Assembly);
        }
    }
}