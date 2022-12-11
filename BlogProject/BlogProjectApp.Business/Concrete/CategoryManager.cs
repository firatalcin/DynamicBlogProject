using BlogProjectApp.Business.Abstract;
using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.Entities.Concrete;

namespace BlogProjectApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public Category Get(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll();
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
