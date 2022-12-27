﻿using BlogProjectApp.DataAccess.Abstract;
using BlogProjectApp.DataAccess.Repositories;
using BlogProjectApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.DataAccess.Concrete.EntityFramework
{
	public class EfNewsLetterDal : RepositoryBase<NewsLetter>, INewsLetterDal
	{

	}
}
