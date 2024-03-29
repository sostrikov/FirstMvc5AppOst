﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FirstMvc5App.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("FirstMvc5AppContext") //смотри имя соединения в Web.config
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}