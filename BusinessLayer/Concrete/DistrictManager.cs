using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class DistrictManager : GenericService<District>
    {
        IDistrictRepository _district;
        public DistrictManager(IDistrictRepository district)
        {
            _district = district;
        }

        public void Add(District p)
        {
            _district.Add(p);
        }

        public void Delete(District p)
        {
            _district.Delete(p);
        }

        public District GetById(int id)
        {
            return _district.GetById(id);
        }

        public List<District> List()
        {
            return _district.List();
        }

        public List<District> List(Expression<Func<District, bool>> filter)
        {
            return _district.List(filter);
        }

        public void Update(District p)
        {
            _district.Update(p);
        }
    }
}
