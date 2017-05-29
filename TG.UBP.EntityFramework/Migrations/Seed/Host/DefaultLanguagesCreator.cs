using System.Collections.Generic;
using System.Linq;
using Abp.Localization;
using TG.UBP.EntityFramework;
using System.Threading.Tasks;
using Abp.Domain.Uow;
using System.Transactions;
using Abp.Transactions.Extensions;

namespace TG.UBP.Migrations.Seed.Host
{
    public class DefaultLanguagesCreator
    {
        public static List<ApplicationLanguage> InitialLanguages { get; private set; }

        private readonly UBPDbContext _context;

        static DefaultLanguagesCreator()
        {
            InitialLanguages = new List<ApplicationLanguage>
            {
                new ApplicationLanguage(null, "en", "English", "famfamfam-flag-gb"),
                new ApplicationLanguage(null, "ar", "العربية", "famfamfam-flag-sa"),
                new ApplicationLanguage(null, "de", "German", "famfamfam-flag-de"),
                new ApplicationLanguage(null, "it", "Italiano", "famfamfam-flag-it"),
                new ApplicationLanguage(null, "fr", "Français", "famfamfam-flag-fr"),
                new ApplicationLanguage(null, "pt-BR", "Portuguese", "famfamfam-flag-br"),
                new ApplicationLanguage(null, "tr", "Türkçe", "famfamfam-flag-tr"),
                new ApplicationLanguage(null, "ru", "Русский", "famfamfam-flag-ru"),
                new ApplicationLanguage(null, "zh-CN", "简体中文", "famfamfam-flag-cn")
            };
        }

        public DefaultLanguagesCreator(UBPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateLanguages();
        }

        private void CreateLanguages()
        {
            foreach (var language in InitialLanguages)
            {
                AddLanguageIfNotExists(language);
            }
        }

        private void AddLanguageIfNotExists(ApplicationLanguage language)
        {
            if (_context.Languages.Any(l => l.TenantId == language.TenantId && l.Name == language.Name))
            {
                return;
            }

            _context.Languages.Add(language);

            _context.SaveChanges();
        }

        //[UnitOfWork]
        public async Task<List<ApplicationLanguage>> GetAllLanguageAsync()
        {
            return await Task.FromResult(_context.Languages.ToList());
        }

        public List<ApplicationLanguage> GetAllLanguage()
        {
            return _context.Languages.ToList();
        }
    }
}