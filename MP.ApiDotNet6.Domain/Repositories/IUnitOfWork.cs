using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task BegingTransation();
        Task Commit();
        Task Rollback();
    }
}
