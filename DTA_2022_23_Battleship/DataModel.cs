﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace DTA_2022_23_Battleship {
    public class BloggingContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Match> Matches { get; set; }

        public string DbPath { get; }

        public BloggingContext() {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}

