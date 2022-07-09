using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class EfImagesRepository : GenericRepository<Images, DataContext>, IImagesRepository
    {
        private DataContext context;
        public EfImagesRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
