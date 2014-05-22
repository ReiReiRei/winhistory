using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using lib.Models;
using System.Data.SqlClient;

namespace lib.Models
{
    class WinHistoryDbContext:DbContext
    {

        


        public WinHistoryDbContext()
            : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename="+ Environment.CurrentDirectory+@"\db\db.mdf;Integrated Security=True;Connect Timeout=30")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WinHistoryDbContext, Migrations.Configuration>());
             var ensureDLLIsCopied = 
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;  
            

        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<ClientInfo> Clients { get; set; }


    }
}
