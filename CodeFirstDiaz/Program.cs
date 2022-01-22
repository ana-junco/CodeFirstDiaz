﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDiaz
{
    class Program
    {
        public class Post
        {
            public int Id { get; set; }
            public DateTime DatePublised { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }
        public class BlogDbContext : DbContext
        {
            public DbSet<Post> Posts { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
