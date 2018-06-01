using mLibrary.OpenData;
using mLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mLibrary.Database
{
    public class mDbContext : System.Data.Entity.DbContext
    {
        static mDbContext()
        {
            //DbInit dbinit = new DbInit();
            //System.Data.Entity.Database.SetInitializer(dbinit);
        }
        public mDbContext() : base("FarmTran")
        {

        }
        public System.Data.Entity.IDbSet<FarmTran> FarmTrans { get; set; }

    }

    public class DbInit : System.Data.Entity.CreateDatabaseIfNotExists<mDbContext>
    {

        protected override void Seed(mDbContext context)
        {
            base.Seed(context);

        }

        public override void InitializeDatabase(mDbContext context)
        {

            base.InitializeDatabase(context);

            IDbHelper<FarmTran> _rep = new FarmTranTable();


            _rep.Xml_Load().ForEach(item =>
            {
                context.FarmTrans.Add(item);
            });

            context.SaveChanges();
        }
    }
}
