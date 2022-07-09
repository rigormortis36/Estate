using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class AdvertManager : GenericService<Advert>
    {
        IAdvertRepository _advert;
        public AdvertManager(IAdvertRepository advert)
        {
            _advert = advert;
        }
        public void Add(Advert p)
        {
            _advert.Add(p);
        }

        public void Delete(Advert p)
        {
            _advert.Delete(p);
        }

        public Advert GetById(int id)
        {
            return _advert.GetById(id);
        }

        public List<Advert> List()
        {
            return _advert.List();
        }

        public List<Advert> List(Expression<Func<Advert, bool>> filter)
        {
            return _advert.List(filter);
        }

        public void Update(Advert p)
        {
            _advert.Update(p);
        }
    }
}
