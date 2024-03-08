using Bussiness.Dtos.Request;
using Bussiness.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IUserService
    {

        CreateUserResponse Add(CreateUserRequest createUserRequest);

        List<GetAllUserResponse> GetAll();  

    }
}
