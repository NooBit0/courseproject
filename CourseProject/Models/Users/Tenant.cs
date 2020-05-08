using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Models.Users
{
    public class Tenant : User
    {
        public Tenant()
        {
        }

        public Tenant(string fullName, string login, string password)
        {
            FullName = fullName;
            Login = login;
            Password = password;
            Balance = 0;
        }

        public int TenantID { get; set; }

        public float Balance { get; set; }

        public ICollection<TenantRentalPremises> TenantRentalPremises { get; set; }
    }
}
