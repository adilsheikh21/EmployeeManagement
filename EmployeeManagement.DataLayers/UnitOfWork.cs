using EmployeeManagement.Infrastructures.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataLayers
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        private IDbContextTransaction _dbTransaction;

        public UnitOfWork(DataContext dataContext, IServiceProvider serviceProvider)
        {
            //  _dataContext = dataContext;
            _dataContext = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
        }

        public void BeginTransaction()
        {
            _dbTransaction = _dataContext.Database.BeginTransaction();
        }

        public async Task BeginTransactionAsync()
        {
            _dbTransaction = await _dataContext.Database.BeginTransactionAsync();
        }

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dataContext.SaveChangesAsync();
        }

        public void Commit()
        {
            _dbTransaction.Commit();
        }

        public void Rollback()
        {
            _dbTransaction.Rollback();
        }

        public async Task<int> ExecuteSqlCommandAsync(string sqlCommand, params object[] parameters)
        {
            return await _dataContext.Database.ExecuteSqlCommandAsync(sqlCommand, parameters);
        }
    }
}

