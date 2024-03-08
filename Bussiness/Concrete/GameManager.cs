using Bussiness.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class GameManager : IGameService
    {
        IBall _ball;

        public GameManager(IBall ball)
        {
            _ball = ball;
        }

        public void FinishedGame()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            _ball = new List<T>();

            return _ball;
        }

        public void GetPoint()
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
