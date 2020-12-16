using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PonySample.GeneratedCodeCustom
{
    public partial class moviesContext : DbContext
    {
        public moviesContext()
        {
        }

        public moviesContext(DbContextOptions<moviesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<android_metadatum> android_metadata { get; set; }
        public virtual DbSet<director> directors { get; set; }
        public virtual DbSet<movie> movies { get; set; }
        public virtual DbSet<room_master_table> room_master_tables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=TestDataBase\\movies.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<room_master_table>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
