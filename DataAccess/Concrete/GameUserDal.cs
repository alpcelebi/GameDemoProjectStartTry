using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GameUserDal : IGameUserDal
    {
        private List<GameUser> _gameUsers;

        public GameUserDal()
        {
            _gameUsers = new List<GameUser>();

            _gameUsers.Add(new GameUser { Id = 1, FirstName = "Alp Eren", LastName = "ÇELEBİ", Email = "alpcelebi33@gmail.com", UserName = "Alp", CreatedUser = DateTime.Now, Password = "310727" });
            _gameUsers.Add(new GameUser { Id = 2, FirstName = "Tugce", LastName = "ÇELEBİ", Email = "Tugcecetiner32@gmail.com", UserName = "Tgce", CreatedUser = DateTime.Now, Password = "310727" });
            _gameUsers.Add(new GameUser { Id = 1, FirstName = "Yagız Alp ", LastName = "ÇELEBİ", Email = "yagızalpcelebi@gmail.com", UserName = "Yagız", CreatedUser = DateTime.Now, Password = "310727" });
        }

        public void Add(GameUser gameUser)
        {
            _gameUsers.Add(gameUser);
        }

        public void Delete(GameUser gameUser)
        {
            GameUser userToDelete = _gameUsers.SingleOrDefault(u => u.Id == gameUser.Id);

            if (userToDelete != null)
            {
                _gameUsers.Remove(userToDelete);
            }
            else
            {
                throw new InvalidOperationException("Kullanıcı bulunamadı.");
            }
        }

        public List<GameUser> GetAll()
        {
            return _gameUsers;
        }

        public void Update(GameUser gameUser)
        {
            GameUser userToUpdate = _gameUsers.SingleOrDefault(u => u.Id == gameUser.Id);

            if (userToUpdate != null)
            {
                
                userToUpdate.UserName = gameUser.UserName;
                userToUpdate.Email = gameUser.Email;
                userToUpdate.FirstName = gameUser.FirstName;
                userToUpdate.LastName = gameUser.LastName;
                userToUpdate.Password = gameUser.Password;
              
            }
            else
            {
                throw new InvalidOperationException("Kullanıcı bulunamadı.");
            }
        }
    }
}
