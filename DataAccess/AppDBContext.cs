﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListORama.Models;
using Microsoft.EntityFrameworkCore;

namespace ListORama.DataAccess
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<ListGroup> listgroups { get; set; }
        public DbSet<ListGroupUser> listgroupusers { get; set; }
                
    }
}
