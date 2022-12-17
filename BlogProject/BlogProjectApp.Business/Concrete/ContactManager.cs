using BlogProjectApp.Business.Abstract;
using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.Entities.Concrete;

namespace BlogProjectApp.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public Contact Get(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetListAll();
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
