using System.Collections.ObjectModel;

namespace Infrastructure.Repositories
{
    public abstract class Repository<T>
    {
        protected IList<T> List = new Collection<T>();
    }
}
