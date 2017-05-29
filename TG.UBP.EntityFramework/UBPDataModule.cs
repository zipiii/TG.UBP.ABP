using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using TG.UBP.EntityFramework;

namespace TG.UBP
{
    /// <summary>
    /// Entity framework module of the application.
    /// </summary>
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(UBPCoreModule))]
    public class UBPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<UBPDbContext>());

            //Configuration.UnitOfWork.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            //InintDevartOracle();

            IDatabaseInitializer<UBPDbContext> CreateDatabaseInitializer =
                new MigrateDatabaseToLatestVersion<UBPDbContext, Migrations.Configuration>();
            Database.SetInitializer(CreateDatabaseInitializer);

            //web.config (or app.config for non-web projects) file should contain a connection string named "Default".
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
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
