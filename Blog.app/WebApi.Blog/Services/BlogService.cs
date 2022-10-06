using Persistence;
using Entities;

namespace WebApi.Blog.Services;

public class BlogService : IBlogService
{
    private readonly BlogDbContext _context;

    public BlogService(BlogDbContext context)
    {
        _context = context;
    }

    public void Insert(Entities.Blog blog)
    {
        _context.Add(blog);
        _context.SaveChanges();
    }

    public Entities.Blog? GetById(int id)
    {
        return _context.Blogs.FirstOrDefault(b => b.BlogId == id);
    }
}

public interface IBlogService
{
    void Insert(Entities.Blog blog);
    Entities.Blog? GetById(int id);
}