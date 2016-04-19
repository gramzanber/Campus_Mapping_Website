using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using UCOGPS.Models;

namespace UCOGPS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20160419180911_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UCOGPS.Models.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LastDestinationBuilding");

                    b.Property<int>("LastStartingBuilding");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Userid");
                });
        }
    }
}
