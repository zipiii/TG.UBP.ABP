﻿using System.Reflection;
using Abp.AutoMapper;
using Abp.Localization;
using Abp.Modules;
using TG.UBP.Authorization;

namespace TG.UBP
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(typeof(UBPCoreModule))]
    public class UBPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper mappings
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                CustomDtoMapper.CreateMappings(mapper);
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
