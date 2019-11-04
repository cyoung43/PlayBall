using PlayBall.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlayBall.DAL
{
    public class BasketballContext : DbContext
    {
        public BasketballContext() : base("BasketballContext") {}

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<NewPlayer> NewPlayers { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}