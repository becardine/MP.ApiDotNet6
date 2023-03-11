using Microsoft.EntityFrameworkCore.Storage;
using MP.ApiDotNet6.Domain.Repositories;
using MP.ApiDotNet6.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        private IDbContextTransaction _dbTransaction;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task BegingTransation()
        {
            _dbTransaction = await _db.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _dbTransaction.CommitAsync();
        }
        public async Task Rollback()
        {
            await _dbTransaction.RollbackAsync();
        }

        public async void Dispose()
        {
           _dbTransaction?.Dispose();
        }

    }
}
