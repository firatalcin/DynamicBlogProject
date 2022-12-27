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
	public class NewsLetterManager : INewsLetterService
	{

		private readonly INewsLetterDal _newsLetterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal)
		{
			_newsLetterDal = newsLetterDal;
		}

		public void Add(NewsLetter entity)
		{
			_newsLetterDal.Add(entity);
		}

		public void Delete(NewsLetter entity)
		{
			throw new NotImplementedException();
		}

		public NewsLetter Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<NewsLetter> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(NewsLetter entity)
		{
			throw new NotImplementedException();
		}
	}
}
