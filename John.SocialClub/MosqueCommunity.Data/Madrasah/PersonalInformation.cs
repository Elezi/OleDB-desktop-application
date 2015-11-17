using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.Data.Madrasah
{
    class PersonalInformation
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string DateOfBirth { get; set; }
        string Street { get; set; }
        Enum City { get; set; }
        Enum StateProvince { get; set; }
        Enum PostalCode { get; set; }
        string EmailAddress { get; set; }
        string HomePhone { get; set; }
        string MobilePhone { get; set; }
        string Notes { get; set; }
    }
}
