namespace SpaceStation.Repositories.Contracts
{
    using System.Collections.Generic;

    public interface AstronautRepository<T>
    {
        IReadOnlyCollection<T> Models { get; }

        void Add(T model);

        bool Remove(T model);

        T FindByName(string name);
    }
}
