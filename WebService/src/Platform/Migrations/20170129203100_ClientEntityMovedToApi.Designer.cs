﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Platform.DatasAccess;

namespace Platform.Migrations
{
    [DbContext(typeof(PlatformContext))]
    [Migration("20170129203100_ClientEntityMovedToApi")]
    partial class ClientEntityMovedToApi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlatformApi.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Forename");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Clients","Platform");
                });
        }
    }
}
