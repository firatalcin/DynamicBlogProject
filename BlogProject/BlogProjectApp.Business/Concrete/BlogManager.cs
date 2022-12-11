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
            return _blogDal.GetAll();
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public Blog GetBlogById(int id)
        {
            return _blogDal.GetListEx(x => x.Id == id);
        }
    }


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

    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public Comment Get(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetAll();
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }

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
            return _contactDal.GetAll();
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
            return _writerDal.GetAll();
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
