using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> carModels;

        public CarRepository()
        {
            carModels = new List<ICar>();
        }

        public IReadOnlyCollection<ICar> Models 
            => carModels;

        public void Add(ICar model)
        {
            if (model==null)
            {
                throw new ArgumentException("Cannot add null in Car Repository");
            }

            carModels.Add(model);
        }

        public ICar FindBy(string property)
               => carModels.FirstOrDefault(c => c.VIN == property);

        public bool Remove(ICar model)
           => carModels.Remove(model);
    }
}
