using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Blogger.Models;
using Dapper;

namespace Blogger.Repositories
{
  public class BlogsRepository
  {
    private readonly IDbConnection _db;

    public BlogsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Blog> GetAll()
    {
      string sql = "SELECT * FROM blogs;";
      return _db.Query<Blog>(sql).ToList();
    }
  }
}