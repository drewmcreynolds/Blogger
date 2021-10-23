namespace Blogger.Services
{
  public class BlogsService
  {
    private readonly BlogsRepository _br;
      public BlogsService(BlogsRepository br)
      {
        _br = br;
      }
  }
}