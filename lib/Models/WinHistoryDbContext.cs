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

        
        //Следует подумать как подключаться к базе данных получше

        public WinHistoryDbContext()
            : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename="+ Environment.CurrentDirectory+@"\db\db.mdf;Integrated Security=True;Connect Timeout=30")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WinHistoryDbContext, Migrations.Configuration>());
             var ensureDLLIsCopied = 
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;  
            

        }

        /// <summary>
        /// Будет таблицей Messages в БД
        /// </summary>

        public DbSet<Message> Messages { get; set; }

        /// <summary>
        /// Будет таблицей Clients в БД
        /// </summary>
        public DbSet<ClientInfo> Clients { get; set; }


    }
}
