using System;
using System.Linq;
using DemoDB.Data;
using DemoDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DemoDB
{
    public class Repository
    {
        public (Example, IDbContextTransaction) Get()
        {
            try
            {
                Console.WriteLine("start read " + DateTime.Now.ToString());
                var context = new ExampleContext();
                var transaction = context.Database.BeginTransaction(); // Start the transaction

                var result = context
                    .Examples
                    .FromSqlRaw<Example>("SELECT * FROM [DummyDB].[dbo].[Examples] WITH (UPDLOCK, HOLDLOCK) WHERE Id = 2")
                    .First();
                Console.WriteLine("finish read " + DateTime.Now.ToString());

                // Return both the result and the transaction
                return (result, transaction);
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("finito");
            }
        }
    }
}
