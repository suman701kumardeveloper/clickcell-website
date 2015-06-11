using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace clickcell.Models
{
    public class SessionContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
    }

    public class Session
    {
        public Guid ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<int> ImagesViewed { get; set; }
    }

}
