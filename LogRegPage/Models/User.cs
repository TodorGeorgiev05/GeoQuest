using System;
using System.Collections.Generic;


namespace LogRegPage.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }
        public string Grade { get; set; }
        public int? Score { get; set; }
    }
}
