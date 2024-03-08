using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGameUserDal
    {
        void Add (GameUser gameUser);

        void Update(GameUser gameUser);

        void Delete (GameUser gameUser);

        List<GameUser> GetAll ();   
    }
}
