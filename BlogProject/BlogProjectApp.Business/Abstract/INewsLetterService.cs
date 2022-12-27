﻿using BlogProjectApp.Business.Repositories;
using BlogProjectApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Business.Abstract
{
	public interface INewsLetterService : IGenericService<NewsLetter>
	{
	}
}
