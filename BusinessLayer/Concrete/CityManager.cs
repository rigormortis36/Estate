using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class CityManager : GenericService<City>
    {
        ICityRepository _city;
        public CityManager(ICityRepository city)
        {
            _city = city;
        }

        public void Add(City p)
        {
            _city.Add(p);
        }

        public void Delete(City p)
        {
            _city.Delete(p);
        }

        public City GetById(int id)
        {
            return _city.GetById(id);
        }

        public List<City> List()
        {
            return _city.List();
        }

        public List<City> List(Expression<Func<City, bool>> filter)
        {
            return _city.List(filter);
        }

        public void Update(City p)
        {
            _city.Update(p);
        }
    }
}
