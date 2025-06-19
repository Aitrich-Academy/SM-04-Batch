using System;
using System.Collections.Generic;
using MVc_Pet_App.Models;
using Microsoft.EntityFrameworkCore;

namespace MVc_Pet_App.Data;

public partial class PetContext : DbContext
{
    public PetContext()
    {
    }

    public PetContext(DbContextOptions<PetContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Pet> Pets { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source=LENOVOIDEAPAD3;Initial Catalog=SUMIYA;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pet__3214EC07C398C361");

            entity.ToTable("Pet");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Discription).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
         
        });

      
     

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
