using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        private readonly List<IRacer> racerModels;
        public RacerRepository()
        {
            racerModels = new List<IRacer>();
        }
        public IReadOnlyCollection<IRacer> Models 
            => racerModels;

        public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Racer Repository");
            }

            racerModels.Add(model);
        }

        public IRacer FindBy(string property)
                => racerModels.FirstOrDefault(r => r.Username == property);

        public bool Remove(IRacer model)
                   => racerModels.Remove(model);
    }
}
