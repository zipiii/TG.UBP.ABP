using System.Data.Entity.Migrations;
using Abp.Events.Bus;
using Abp.Events.Bus.Entities;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using EntityFramework.DynamicFilters;
using TG.UBP.Migrations.Seed.Host;
using TG.UBP.Migrations.Seed.Tenants;

namespace TG.UBP.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<EntityFramework.UBPDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        private const string ProviderName = "Devart.Data.Oracle";

        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;
            //ContextKey = "UBP";

            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = typeof(EntityFramework.UBPDbContext).FullName;

            SetSqlGenerator(ProviderName, new Devart.Data.Oracle.Entity.Migrations.OracleEntityMigrationSqlGenerator());

            InintDevartOracle();
        }

        protected override void Seed(EntityFramework.UBPDbContext context)
        {
            context.DisableAllFilters();

            context.EntityChangeEventHelper = NullEntityChangeEventHelper.Instance;
            context.EventBus = NullEventBus.Instance;

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantBuilder(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases using Tenant property...
            }

            context.SaveChanges();
        }

        private void InintDevartOracle()
        {
            Devart.Data.Oracle.OracleMonitor monitor = new Devart.Data.Oracle.OracleMonitor() { IsActive = true };
            Devart.Data.Oracle.Entity.Configuration.OracleEntityProviderConfig devartConfig = Devart.Data.Oracle.Entity.Configuration.OracleEntityProviderConfig.Instance;
            devartConfig.Workarounds.IgnoreSchemaName = true;
            devartConfig.Workarounds.DisableQuoting = true;
            devartConfig.CodeFirstOptions.UseDateTimeAsDate = true;
            devartConfig.CodeFirstOptions.UseNonLobStrings = true;
            devartConfig.CodeFirstOptions.UseNonUnicodeStrings = true;
            devartConfig.CodeFirstOptions.TruncateLongDefaultNames = true;
            //devartConfig.DatabaseScript.Column.MaxStringSize = Devart.Data.Oracle.Entity.Configuration.OracleMaxStringSize.Standard;
        }
    }
}
