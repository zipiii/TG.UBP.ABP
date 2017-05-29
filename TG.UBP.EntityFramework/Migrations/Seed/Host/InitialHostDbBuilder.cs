﻿using TG.UBP.EntityFramework;

namespace TG.UBP.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly UBPDbContext _context;

        public InitialHostDbBuilder(UBPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
