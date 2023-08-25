using AmmyBlogging.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmyBlogging.Data
{
    public class AmmyBloggingDbContext : DbContext
    {
        public AmmyBloggingDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var item in modelBuilder.Model.GetEntityTypes().SelectMany(e=>e.GetForeignKeys()))
            {
               item.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserReload> UserReloads { get; set; }
        public DbSet<Post> Posts   { get; set; }
        public DbSet<PostComment> PostComments  { get; set; }
        public DbSet<PostReaction> PostReactions  { get; set; }
        public DbSet<PostStatus> PostStatuses  { get; set; }
        public DbSet<ReactionTyped> reactionTypeds   { get; set; }
        public DbSet<Category> categories   { get; set; }
        
    }
}
