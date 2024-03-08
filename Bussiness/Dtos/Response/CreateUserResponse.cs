using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dtos.Response
{
    public class CreateUserResponse
    {

        public int Id { get; set; }

        public string UserName { get; set; }    

        public DateTime CreatedDate { get; set; }


    }
}
