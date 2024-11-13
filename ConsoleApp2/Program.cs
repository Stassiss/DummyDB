using System;
using System.Threading;
using DemoDB;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("sec");
                Thread.Sleep(1000);
                var repo = new Repository();
                var (e, transaction) = repo.Get();
                transaction.Commit();
                Console.WriteLine(e.Id);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
