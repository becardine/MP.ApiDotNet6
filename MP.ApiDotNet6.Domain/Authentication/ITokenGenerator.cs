using MP.ApiDotNet6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Domain.Authentication
{
    public interface ITokenGenerator
    {
        dynamic Generator(User user);
    }
}
