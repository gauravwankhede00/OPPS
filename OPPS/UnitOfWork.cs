using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace OPPS
{
    //By using the Unit of Work pattern,
    //you can ensure that multiple database operations are grouped together and committed or rolled back
    //as a single unit.This pattern promotes data consistency and transactional integrity
    //while providing a clean and abstracted interface for working with database operations in your application
    interface IUnitOfWork
    {
        void Commit();
        void RoleBack();
        void BeginTransaction();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductDBContext dBContext;
        private IDbContextTransaction transaction;
        public UnitOfWork(ProductDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public void BeginTransaction()
        {
            transaction = dBContext.Database.BeginTransaction();
        }
        public void Commit()
        {
            dBContext.SaveChanges();
            transaction.Commit();
        }
        public void RoleBack()
        {
            transaction.Rollback();
        }
    }

    public class ProductDBContext : DbContext
    {
        public ProductDBContext() { }
    }
}
