using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratorDemo.Models
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
        public void Migrated(string migrated)
        {
            Console.WriteLine(migrated);
        }
    }
}
