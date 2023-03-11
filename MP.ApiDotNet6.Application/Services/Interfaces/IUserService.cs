using MP.ApiDotNet6.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResultService<dynamic>> GenerateTokenAsync(UserDTO userDTO);
    }
}
