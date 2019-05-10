using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using kiyas.la.Entities;

namespace kiyas.la.Context
{
    public class KiyaslaContext : DbContext
    {
        public DbSet<Phone> SmartPhone { get; set; }

        public DbSet<Comment> Yorum { get; set; }
    }
}