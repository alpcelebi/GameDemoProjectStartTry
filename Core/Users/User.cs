using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Users
{
    public class User<TId>
    {
        public TId Id { get; set; } 

        public string FirstName { get; set; }    

        public string LastName { get; set; }


        public string Email { get; set; }   


        public string Password { get; set; }

        public string UserName { get; set;  }


        public DateTime CreatedUser { get; set; }

        public DateTime? UpdateUser { get; set; }

        public DateTime? DeleteUser { get; set;}

    }
}
