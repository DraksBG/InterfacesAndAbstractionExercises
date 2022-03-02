using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T07.Contracts;
using T07.Models;

namespace T07.Core
{
    public class Engine
    {
        private List<ISoldier> _soldiers;

        public Engine()
        {
            this._soldiers = new List<ISoldier>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                string type = tokens[0];
                string id = tokens[1];
                string firstName = tokens[2];
                string lastName = tokens[3];
                decimal salary = decimal.Parse(tokens[4]);

                if (type == "Private")
                {
                    ISoldier @private = new Private(id, firstName, lastName, salary);
                    this._soldiers.Add(@private);
                }
                else if (type == "LieutenantGeneral")
                {
                    LieutenantGeneral lieutenant = new LieutenantGeneral(id, firstName, lastName, salary);
                    string[] privateIds = tokens.Skip(5).ToArray();
                    foreach (var privateId in privateIds)
                    {
                        ISoldier currentPrivate = this._soldiers.FirstOrDefault(x => x.Id == privateId);
                        lieutenant.AddPrivate(currentPrivate);
                    }
                    this._soldiers.Add(lieutenant);
                }
                else if (type == "Engineer")
                {
                    try
                    {
                        string corps = tokens[5];
                        Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                        string[] repairs = tokens.Skip(6).ToArray();
                        for (int i = 0; i < repairs.Length; i+=2)
                        {
                            string repPart = repairs[i];
                            int hourForRep = int.Parse(repairs[i + 1]);
                            IRepair repair = new Repair(repPart, hourForRep);
                            engineer.AddRepair(repair);
                        }
                        this._soldiers.Add(engineer);
                    }
                    catch (Exception)
                    {
                       
                    }
                } 
                else if (type == "Commando")
                {
                    try
                    {
                        string corps = tokens[5];
                        Commando commando = new Commando(id, firstName, lastName, salary, corps);
                        string[] missionInfo = tokens.Skip(6).ToArray();
                        for (int i = 0; i < missionInfo.Length; i+=2)
                        {
                            string missionName = missionInfo[i];
                            string state = missionInfo[i + 1];
                            IMission mission;
                            try
                            {
                                mission = new Mission(missionName, state);
                            }
                            catch (Exception )
                            {
                               continue;
                            }
                            commando.AddMission(mission);
                        }
                        this._soldiers.Add(commando);
                    }
                    catch (Exception e)
                    {
                       
                    }
                }
                else if (type == "Spy")
                {
                    int codeNUmber = (int) salary;
                    ISpy spy = new Spy(id, firstName, lastName, codeNUmber);
                    this._soldiers.Add(spy);
                }

                input = Console.ReadLine();
            }

            foreach (var soldier in _soldiers)
            {
                Type type = soldier.GetType();
                Object actualSoldier = Convert.ChangeType(soldier, type);
                Console.WriteLine(actualSoldier);
            }
        }
    }
}
