using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public DateTime Inserted { get; set; }
}