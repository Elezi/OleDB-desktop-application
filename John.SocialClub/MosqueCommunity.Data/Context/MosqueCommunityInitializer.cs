using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MosqueCommunity.Data.Madrasah;


namespace MosqueCommunity.Data.Context
{
    class MosqueCommunityInitializer : CreateDatabaseIfNotExists<MosqueCommunityDBContext>
    {
            protected override void Seed(MosqueCommunityDBContext context)
            {
                var personalInformations = new List<PersonalInformation>{
                new PersonalInformation {  },
                new PersonalInformation {  },
                new PersonalInformation { },
            };

                personalInformations.ForEach(category => context.PersonalInformations.Add(category));
            }
    }
}
