﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220529233951_lastmig")]
    partial class lastmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DayTaskContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DayTime")
                        .HasColumnType("int");

                    b.Property<int?>("TaskImportanceID")
                        .HasColumnType("int");

                    b.Property<int?>("TaskStatuseID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("DayId");

                    b.HasIndex("TaskImportanceID");

                    b.HasIndex("TaskStatuseID");

                    b.HasIndex("UserID");

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

                    b.Property<int>("MonthTime")
                        .HasColumnType("int");

                    b.Property<int?>("TaskImportanceID")
                        .HasColumnType("int");

                    b.Property<int?>("TaskStatuseID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("MonthID");

                    b.HasIndex("TaskImportanceID");

                    b.HasIndex("TaskStatuseID");

                    b.HasIndex("UserID");

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

                    b.Property<int?>("TaskImportanceID")
                        .HasColumnType("int");

                    b.Property<int?>("TaskStatuseID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("WeekTaskContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeekTime")
                        .HasColumnType("int");

                    b.HasKey("WeekID");

                    b.HasIndex("TaskImportanceID");

                    b.HasIndex("TaskStatuseID");

                    b.HasIndex("UserID");

                    b.ToTable("TblWeek");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Day", b =>
                {
                    b.HasOne("EntityLayer.Concrete.TaskImportance", "TaskImportance")
                        .WithMany("Day")
                        .HasForeignKey("TaskImportanceID");

                    b.HasOne("EntityLayer.Concrete.TaskStatuse", "TaskStatuse")
                        .WithMany("Day")
                        .HasForeignKey("TaskStatuseID");

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("Day")
                        .HasForeignKey("UserID");

                    b.Navigation("TaskImportance");

                    b.Navigation("TaskStatuse");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Month", b =>
                {
                    b.HasOne("EntityLayer.Concrete.TaskImportance", "TaskImportance")
                        .WithMany("Month")
                        .HasForeignKey("TaskImportanceID");

                    b.HasOne("EntityLayer.Concrete.TaskStatuse", "TaskStatuse")
                        .WithMany("Month")
                        .HasForeignKey("TaskStatuseID");

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("Month")
                        .HasForeignKey("UserID");

                    b.Navigation("TaskImportance");

                    b.Navigation("TaskStatuse");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Week", b =>
                {
                    b.HasOne("EntityLayer.Concrete.TaskImportance", "TaskImportance")
                        .WithMany("Week")
                        .HasForeignKey("TaskImportanceID");

                    b.HasOne("EntityLayer.Concrete.TaskStatuse", "TaskStatuse")
                        .WithMany("Week")
                        .HasForeignKey("TaskStatuseID");

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("Week")
                        .HasForeignKey("UserID");

                    b.Navigation("TaskImportance");

                    b.Navigation("TaskStatuse");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TaskImportance", b =>
                {
                    b.Navigation("Day");

                    b.Navigation("Month");

                    b.Navigation("Week");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TaskStatuse", b =>
                {
                    b.Navigation("Day");

                    b.Navigation("Month");

                    b.Navigation("Week");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Navigation("Day");

                    b.Navigation("Month");

                    b.Navigation("Week");
                });
#pragma warning restore 612, 618
        }
    }
}