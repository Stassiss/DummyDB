﻿using System;
using System.Threading;

namespace DemoDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("firsts");
                var repo = new Repository();
                var (e, transaction) = repo.Get();

                Console.WriteLine(e.Id);
                Thread.Sleep(3000);
                transaction.Commit();
                Console.ReadLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
