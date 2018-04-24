using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class StudentAddress
    {
        public int StudentAddressID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        // foreign key 
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
    }
}
