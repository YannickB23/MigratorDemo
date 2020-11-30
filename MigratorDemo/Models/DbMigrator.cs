using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratorDemo.Models
{
    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("We're migrating to database");
            _logger.Migrated("Is migrated");
        }
    }
}
