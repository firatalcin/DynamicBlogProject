using BlogProjectApp.Business.Abstract;
using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Business.Concrete
{

    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog entity)
        {
            _blogDal.Add(entity);
        }

        public Blog Get(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.Id == id);
        }
    }
}
