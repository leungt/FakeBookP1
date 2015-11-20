﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SuperHero.Models
{
    public class Friend
    {
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }

        public DateTime DateFriended { get; set; }
    }

    public class FriendDbContext : DbContext
    {
        public DbSet<Friend> Friend { get; set; }
    }
}