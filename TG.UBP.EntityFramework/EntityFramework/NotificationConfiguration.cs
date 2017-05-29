using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TG.UBP.EntityFramework
{
    public class NotificationConfiguration : EntityTypeConfiguration<Abp.Notifications.NotificationInfo>
    {
        public NotificationConfiguration()
        {
            Property(j => j.EntityTypeAssemblyQualifiedName)
                .HasColumnName("EntityTypeAssemblyQualified");
            Property(j => j.Data)
                .HasMaxLength(4000);
            Property(j => j.UserIds)
                .HasMaxLength(4000);
            Property(j => j.ExcludedUserIds)
                .HasMaxLength(4000);
            Property(j => j.TenantIds)
                .HasMaxLength(4000);
        }
    }

    public class NotificationSubscriptionConfiguration : EntityTypeConfiguration<Abp.Notifications.NotificationSubscriptionInfo>
    {
        public NotificationSubscriptionConfiguration()
        {
            Property(j => j.EntityTypeAssemblyQualifiedName)
                .HasColumnName("EntityTypeAssemblyQualified");
        }
    }

    public class UserConfiguration : EntityTypeConfiguration<TG.UBP.Authorization.Users.User>
    {
        public UserConfiguration()
        {
            Property(j => j.ShouldChangePasswordOnNextLogin)
                .HasColumnName("ShouldChangePwdOnNextLogin");
        }
    }

    public class TenantNotificationConfiguration : EntityTypeConfiguration<Abp.Notifications.TenantNotificationInfo>
    {
        public TenantNotificationConfiguration()
        {
            Property(j => j.EntityTypeAssemblyQualifiedName)
                .HasColumnName("EntityTypeAssemblyQualified");
            Property(j => j.Data)
                .HasMaxLength(4000);
        }
    }

    public class BackgroundJobConfiguration : EntityTypeConfiguration<Abp.BackgroundJobs.BackgroundJobInfo>
    {
        public BackgroundJobConfiguration()
        {
            Property(j => j.JobArgs)
                .HasMaxLength(4000);
        }
    }

    public class ChatMessageConfiguration : EntityTypeConfiguration<TG.UBP.Chat.ChatMessage>
    {
        public ChatMessageConfiguration()
        {
            Property(j => j.Message)
                .HasMaxLength(4000);
        }
    }

    public class ApplicationLanguageTextConfiguration : EntityTypeConfiguration<Abp.Localization.ApplicationLanguageText>
    {
        public ApplicationLanguageTextConfiguration()
        {
            Property(j => j.Value)
                .HasMaxLength(4000);
        }
    }
}
