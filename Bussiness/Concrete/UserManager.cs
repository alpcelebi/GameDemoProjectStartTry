using Bussiness.Abstract;
using Bussiness.Dtos.Request;
using Bussiness.Dtos.Response;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IGameUserDal _gameUserDal;

        public UserManager(IGameUserDal gameUserDal)
        {
            _gameUserDal = gameUserDal;
        }

        public CreateUserResponse Add(CreateUserRequest createUserRequest)
        {
            GameUser gameUser = new();

            gameUser.UserName= createUserRequest.UserName;  
            gameUser.CreatedUser=DateTime.Now;

            _gameUserDal.Add(gameUser); 


            CreateUserResponse createUserResponse = new CreateUserResponse();
            createUserResponse.UserName=gameUser.UserName;
            createUserResponse.CreatedDate = gameUser.CreatedUser;
            

            return createUserResponse;  

        }

        public List<GetAllUserResponse> GetAll()
        {

            List<GameUser> gameUsers = _gameUserDal.GetAll();
            
            List<GetAllUserResponse> getAllUserResponses = new List<GetAllUserResponse>();

            foreach (var gameUser in gameUsers)
            {

                GetAllUserResponse getAllUserResponse = new GetAllUserResponse();

                getAllUserResponse.UserName=gameUser.UserName;  
                getAllUserResponse.Id=gameUser.Id;
                getAllUserResponse.CreatedUser=gameUser.CreatedUser;    
             
                 getAllUserResponses.Add(getAllUserResponse);   

            }

            return getAllUserResponses; 



        }
    }
}
