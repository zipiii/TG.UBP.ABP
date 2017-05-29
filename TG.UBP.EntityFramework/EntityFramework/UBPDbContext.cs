using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using TG.UBP.Authorization.Roles;
using TG.UBP.Authorization.Users;
using TG.UBP.Chat;
using TG.UBP.Friendships;
using TG.UBP.MultiTenancy;
using TG.UBP.Storage;

namespace TG.UBP.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class UBPDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public UBPDbContext()
            : base("Default")
        {
            
        }

        public UBPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public UBPDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public UBPDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.HasDefaultSchema("ABP");

            //modelBuilder.Entity<Abp.Notifications.NotificationInfo>()
            //    .ToTable("NotificationInfo")
            //    .Property(j => j.EntityTypeAssemblyQualifiedName)
            //    .HasColumnName("EntityTypeAssemblyQualified");

            //modelBuilder.Entity<Abp.Notifications.NotificationSubscriptionInfo>()
            //    .Property(j => j.EntityTypeAssemblyQualifiedName)
            //    .HasColumnName("EntityTypeAssemblyQualified");

            //modelBuilder.Entity<User>()
            //    .Property(j => j.ShouldChangePasswordOnNextLogin)
            //    .HasColumnName("ShouldChangePwdOnNextLogin");

            modelBuilder.Configurations.Add(new NotificationConfiguration());
            modelBuilder.Configurations.Add(new NotificationSubscriptionConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new TenantNotificationConfiguration());
            modelBuilder.Configurations.Add(new BackgroundJobConfiguration());
            modelBuilder.Configurations.Add(new ChatMessageConfiguration());
            modelBuilder.Configurations.Add(new ApplicationLanguageTextConfiguration());

        }
    }
}
