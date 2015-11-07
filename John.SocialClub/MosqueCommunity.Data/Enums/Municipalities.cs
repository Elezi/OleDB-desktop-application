using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MosqueCommunity.Data.Enums
{
    public class CitiesDictionary
    {
        public List<string> CityNamesList;
        public List<string> MunicipalitiesList;
        public Dictionary<string, string> MunicipalitiesDictionary;
        public CitiesDictionary()
        {

            MunicipalitiesDictionary =
            new Dictionary<string, string> 
            {
                {"Bogovina","Tetova"},
                {"Cairi","Shkupi"},
                {"Dellogozhda","Struga"},
                {"Drenoc","Tetova"},
                {"Likova","Shkupi"},
                {"Rostushe","Dibra"},
                {"Saraj","Shkupi"},
                {"Tearca","Tetova"},
                {"Vrapcishti","Gostivari"},
                {"Zhelina","Tetova"}
            };

                 CityNamesList  = new List<string>
                {
                    "Tetova",
                    "Gostivari",
                    "Shkupi",
                    "Dibra",
                    "Struga",
                    "Ohri",
                    "Kumanova",
                    "Kercova"
                };
                 MunicipalitiesList = new List<string> 
            {
                "Zhelina",
                "Tearca",
                "Bogovina",
                "Likova",
                "Cairi",
                "Saraj",
                "Rostushe",
                "Vrapcishti",
                "Dellogozhda",
                "Drenoc"
            };
        }
    }
}
