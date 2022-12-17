using BlogProjectApp.Business.Abstract;
using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.Entities.Concrete;

namespace BlogProjectApp.Business.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer entity)
        {
            _writerDal.Add(entity);
        }

        public Writer Get(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.GetListAll();
        }

        public void Delete(Writer entity)
        {
            _writerDal.Delete(entity);
        }

        public void Update(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
