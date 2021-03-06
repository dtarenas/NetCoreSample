﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreSample.DAL.DAL;

namespace NetCoreSample.Web.MVC.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200719224203_AddAuthorsField")]
    partial class AddAuthorsField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NetCoreSample.Models.Entities.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("varchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UrlCoverPicture")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("NetCoreSample.Models.Entities.Remarks", b =>
                {
                    b.Property<int>("RemarksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<int>("FkCourseId")
                        .HasColumnType("int");

                    b.Property<int?>("FkCoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("Qualification")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("RemarksId");

                    b.HasIndex("FkCoursesCourseId");

                    b.ToTable("Remarks");
                });

            modelBuilder.Entity("NetCoreSample.Models.Entities.Remarks", b =>
                {
                    b.HasOne("NetCoreSample.Models.Entities.Courses", "FkCourses")
                        .WithMany("FkRemarks")
                        .HasForeignKey("FkCoursesCourseId");
                });
#pragma warning restore 612, 618
        }
    }
}
