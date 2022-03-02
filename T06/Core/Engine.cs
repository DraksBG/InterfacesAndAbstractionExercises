using System;
using System.Collections.Generic;
using System.Linq;
using T04.Models;
using T06;
using T06.Contracts;

namespace T04.Core
{
    public class Engine
    {
        private List<IBuyer> repository;
        private IBuyer curBuyer;
        private IBuyer newBuyer;

        public Engine()
        {
            this.repository = new List<IBuyer>();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            FillRepository(n);

            string input = Console.ReadLine();
            while (input != "End")
            {

                newBuyer = FindNameOfBuyer(input);
                newBuyer?.BuyFood();
                input = Console.ReadLine();
            }
            PrintFinalResult();
        }

        private void FillRepository(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] buyersInfo = Console.ReadLine().Split();
                string name = buyersInfo[0];
                int age = int.Parse(buyersInfo[1]);
                IBuyer buyer = null;
                switch (buyersInfo.Length)
                {
                    case 3:
                        {
                            string group = buyersInfo[2];
                            buyer = new Rebel(name, age, group);
                            break;
                        }
                    case 4:
                        {
                            string id = buyersInfo[2];
                            string birthdate = buyersInfo[3];
                            buyer = new Citizen(id, name, age, birthdate);
                            break;
                        }
                }

                if (buyer != null)
                {
                    this.repository.Add(buyer);
                }

            }
        }

        private void PrintFinalResult()
            =>  Console.WriteLine(repository.Sum(buyer => buyer.Food));
        

        private IBuyer FindNameOfBuyer(string nameOfBuyer)
        => curBuyer = this.repository.FirstOrDefault(cb => cb.Name == nameOfBuyer);


    }
}
