using System;
using System.Globalization;
using System.Web;
using Abp.Castle.Logging.Log4Net;
using Abp.Configuration;
using Abp.Localization;
using Abp.Logging;
using Abp.Timing;
using Abp.Extensions;
using Abp.Web;
using Castle.Facilities.Logging;
using EntityFramework.DynamicFilters;
using Abp.Threading;
using System.Transactions;
using System.Data.Entity;
using Abp.Transactions.Extensions;

namespace TG.UBP.Web
{
    public class MvcApplication : AbpWebApplication<UBPWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            //Use UTC clock. Remove this to use local time for your application.
            Clock.Provider = ClockProviders.Utc;

            //Log4Net configuration
            AbpBootstrapper.IocManager.IocContainer
                .AddFacility<LoggingFacility>(f => f.UseAbpLog4Net()
                    .WithConfig("log4net.config")
                );

            base.Application_Start(sender, e);
        }

        protected override void Session_Start(object sender, EventArgs e)
        {
            RestoreUserLanguage();
            base.Session_Start(sender, e);
        }

        private void RestoreUserLanguage()
        {
            Devart.Data.Oracle.OracleMonitor monitor = new Devart.Data.Oracle.OracleMonitor() { IsActive = true };
            Devart.Data.Oracle.Entity.Configuration.OracleEntityProviderConfig devartConfig = Devart.Data.Oracle.Entity.Configuration.OracleEntityProviderConfig.Instance;
            devartConfig.Workarounds.IgnoreSchemaName = true;
            devartConfig.Workarounds.DisableQuoting = true;
            devartConfig.CodeFirstOptions.UseDateTimeAsDate = true;
            devartConfig.CodeFirstOptions.UseNonLobStrings = true;
            devartConfig.CodeFirstOptions.UseNonUnicodeStrings = true;
            devartConfig.CodeFirstOptions.TruncateLongDefaultNames = true;
            //EntityFramework.UBPDbContext dbcontext = new EntityFramework.UBPDbContext("Default");
            //dbcontext.DisableAllFilters();
            //Migrations.Seed.Host.DefaultLanguagesCreator lang = new Migrations.Seed.Host.DefaultLanguagesCreator(dbcontext);
            //DbContextTransaction trx = dbcontext.Database.BeginTransaction(IsolationLevel.ReadCommitted.ToSystemDataIsolationLevel());
            //var list = AsyncHelper.RunSync(() => lang.GetAllLanguageAsync());
            ////var list = lang.GetAllLanguage();
            //trx.Commit();

            var settingManager = AbpBootstrapper.IocManager.Resolve<ISettingManager>();
            var defaultLanguage = settingManager.GetSettingValue(LocalizationSettingNames.DefaultLanguage);
            //var defaultLanguage = "zh-CN";

            if (defaultLanguage.IsNullOrEmpty())
            {
                return;
            }

            try
            {
                CultureInfo.GetCultureInfo(defaultLanguage);
                Response.Cookies.Add(new HttpCookie("Abp.Localization.CultureName", defaultLanguage) { Expires = Clock.Now.AddYears(2) });
            }
            catch (CultureNotFoundException exception)
            {
                LogHelper.Logger.Warn(exception.Message, exception);
            }
        }

        /* Preventing client side cache */
        private static readonly DateTime CacheExpireDate = new DateTime(2000, 1, 1);
        protected override void Application_BeginRequest(object sender, EventArgs e)
        {
            base.Application_BeginRequest(sender, e);
            DisableClientCache();
        }

        private void DisableClientCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(CacheExpireDate);
            Response.Cache.SetNoStore();
        }
    }
}
