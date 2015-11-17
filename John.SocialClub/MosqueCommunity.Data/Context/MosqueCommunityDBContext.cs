using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MosqueCommunity.Data.Madrasah;

namespace MosqueCommunity.Data.Context
{
    class MosqueCommunityDBContext: DbContext
    {

        public MosqueCommunityDBContext()
                : base("MosqueCommunity.DbConnection")
            {
                Database.SetInitializer<MosqueCommunityDBContext>(new MosqueCommunityInitializer());
                Configuration.ProxyCreationEnabled = false;
            }

        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        }
}
