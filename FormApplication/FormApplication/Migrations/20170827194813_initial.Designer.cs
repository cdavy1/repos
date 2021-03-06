﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FormApplication.Models;

namespace FormApplication.Migrations
{
    [DbContext(typeof(PlanContext))]
    [Migration("20170827194813_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FormApplication.Models.BCPPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<int>("CustomerId");

                    b.Property<string>("PlanName");

                    b.Property<string>("ThePlan");

                    b.HasKey("Id");

                    b.ToTable("BCPPlan");
                });
        }
    }
}
