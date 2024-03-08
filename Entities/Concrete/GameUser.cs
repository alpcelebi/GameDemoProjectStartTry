using Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GameUser:User<int>
    {
        public int point {  get; set; }
       
    }
}
