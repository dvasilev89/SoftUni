using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models
{
    public abstract class Procedure : IProcedure
    {
        private List<IAnimal> procedureHistory;

        public Procedure()
        {
            this.ProcedureHistory = new List<IAnimal>();
        }

        public List<IAnimal> ProcedureHistory
        {
            get { return procedureHistory; }
            protected set { procedureHistory = value; }
        }        

        public void DoService(IAnimal animal, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string History()
        {
            return $"";
        }
    }
}
