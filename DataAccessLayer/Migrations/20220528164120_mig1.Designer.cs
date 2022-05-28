﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220528164120_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("TblAdmin");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DayTaskContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DayTaskFinishTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DayTime")
                        .HasColumnType("int");

                    b.HasKey("DayId");

                    b.ToTable("TblDay");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Month", b =>
                {
                    b.Property<int>("MonthID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MonthTaskContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MonthTaskFinishTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthTime")
                        .HasColumnType("int");

                    b.HasKey("MonthID");

                    b.ToTable("TblMonth");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TaskImportance", b =>
                {
                    b.Property<int>("TaskImportanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaskImportanceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskImportanceID");

                    b.ToTable("TblTaskImportance");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TaskStatuse", b =>
                {
                    b.Property<int>("TaskStatuseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaskStatuseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskStatuseID");

                    b.ToTable("TblTaskStatus");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("TblUser");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Week", b =>
                {
                    b.Property<int>("WeekID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WeekTaskContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeekTaskFinishTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeekTime")
                        .HasColumnType("int");

                    b.HasKey("WeekID");

                    b.ToTable("TblWeek");
                });
#pragma warning restore 612, 618
        }
    }
}
