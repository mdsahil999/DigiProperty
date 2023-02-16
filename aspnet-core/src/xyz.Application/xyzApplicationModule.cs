using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using xyz.Authorization;

namespace xyz
{
    [DependsOn(
        typeof(xyzCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class xyzApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<xyzAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(xyzApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
