using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private ICollection<ISoldier> soldiers;
        private ISoldier soldier;

        public Engine()
        {
            this.soldiers = new List<ISoldier>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArrgs = Console.ReadLine().Split();

                string type = inputArrgs[0];
                int id = int.Parse(inputArrgs[1]);
                string firstName = inputArrgs[2];
                string lastName = inputArrgs[3];

                if (type == "Private")
                {
                    decimal salary = decimal.Parse(inputArrgs[4]);
                    soldier = GetPrivateSoldier(id, firstName, lastName, salary);
                }
                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputArrgs[4]);
                    soldier = GetLieutenantGeneral(id, firstName, lastName, salary, inputArrgs);
                }
                else if (type == "Engineer")
                {
                    decimal salary = decimal.Parse(inputArrgs[4]);
                    soldier = GetEngineer(id, firstName, lastName, salary, inputArrgs);
                }
                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(inputArrgs[4]);
                    soldier = GetCommando(id, firstName, lastName, salary, inputArrgs);
                }
                else if (type == "Spy")
                {
                    int codeNumber = int.Parse(inputArrgs[4]);
                    soldier = GetSpy(id, firstName, lastName, codeNumber);
                }

                if (soldier != null)
                {
                    soldiers.Add(soldier);
                }

                input = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private ISoldier GetSpy(int id, string firstName, string lastName, int codeNumber)
        {
            ISpy spy = new Spy(id, firstName, lastName, codeNumber);

            return spy;
        }

        private ISoldier GetCommando(int id, string firstName, string lastName, decimal salary, string[] inputArrgs)
        {
            string corpsAsString = inputArrgs[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }

            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            for (int i = 6; i < inputArrgs.Length; i += 2)
            {
                string codeName = inputArrgs[i];
                string stateAsString = inputArrgs[i + 1];

                if (!Enum.TryParse(stateAsString, out State state))
                {
                    continue;
                }

                IMission mission = new Mission(codeName, state);

                commando.Missions.Add(mission);
            }

            return commando;
        }

        private ISoldier GetEngineer(int id, string firstName, string lastName, decimal salary, string[] inputArrgs)
        {
            string corpsAsString = inputArrgs[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }

            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            for (int i = 6; i < inputArrgs.Length; i += 2)
            {
                string partName = inputArrgs[i];
                int workedHours = int.Parse(inputArrgs[i + 1]);

                IRepair repair = new Repair(partName, workedHours);

                engineer.Repairs.Add(repair);
            }

            return engineer;
        }

        private ISoldier GetLieutenantGeneral(int id, string firstName, string lastName, decimal salary, string[] inputArrgs)
        {
            ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

            for (int i = 5; i < inputArrgs.Length; i++)
            {
                int privateId = int.Parse(inputArrgs[i]);
                IPrivate privateSoldier = (Private)soldiers.FirstOrDefault(x => x.Id == privateId);

                lieutenantGeneral.Privates.Add(privateSoldier);
            }

            return lieutenantGeneral;
        }

        private ISoldier GetPrivateSoldier(int id, string firstName, string lastName, decimal salary)
        {
            IPrivate privateSoldier = new Private(id, firstName, lastName, salary);

            return privateSoldier;
        }
    }
}
