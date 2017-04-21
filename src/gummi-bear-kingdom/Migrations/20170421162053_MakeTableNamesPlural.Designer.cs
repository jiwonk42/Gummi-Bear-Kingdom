using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using gummi_bear_kingdom.Models;

namespace gummibearkingdom.Migrations
{
    [DbContext(typeof(GummiBearDbContext))]
    [Migration("20170421162053_MakeTableNamesPlural")]
    partial class MakeTableNamesPlural
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("gummi_bear_kingdom.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("Name");

                    b.Property<string>("Origin");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });
        }
    }
}
