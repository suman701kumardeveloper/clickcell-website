using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace clickcell.Models
{
    public class ImageContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
    }

    public class Image
    {
        public int ID { get; set; }
        public int ViewCount { get; set; }
        public int ExpandedViewCount { get; set; }
        public int HideCount { get; set; }
        public string Title { get; set; }
        public string URI { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<int> CategoryIDs { get; set; }
    }
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}