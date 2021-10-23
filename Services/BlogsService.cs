using System;
using System.Collections.Generic;
using Blogger.Models;
using Blogger.Repositories;

namespace Blogger.Services
{
  public class BlogsService
  {
    private readonly BlogsRepository _br;
      public BlogsService(BlogsRepository br)
      {
        _br = br;
      }

    public List<Blog> GetAll()
    {
    return _br.GetAll();
    }
  }
}