using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.Data.Madrasah
{
   public class Premise
    {
       string addreess;
       int floor;
       char PremiseIndex;
       string PremiseName { get { return floor.ToString() + PremiseIndex; } } 
    }
}
