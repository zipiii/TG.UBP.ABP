using EntityFramework.DynamicFilters;
using TG.UBP.EntityFramework;

namespace TG.UBP.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly UBPDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(UBPDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
