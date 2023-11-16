﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Xivotec.CleanArchitecture.Infrastructure.PostgreSQLPort;

#nullable disable

namespace Xivotec.CleanArchitecture.Infrastructure.PostgreSQLPort.Migrations
{
    [DbContext(typeof(PostgresPortDataContext))]
    partial class PostgresPortDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Xivotec.CleanArchitecture.Domain.ToDoListAggregate.Entities.ToDoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Done")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ListId")
                        .HasColumnType("uuid");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Reminder")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("Xivotec.CleanArchitecture.Domain.ToDoListAggregate.Entities.ToDoList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TodoLists");
                });

            modelBuilder.Entity("Xivotec.CleanArchitecture.Domain.ToDoListAggregate.Entities.ToDoItem", b =>
                {
                    b.HasOne("Xivotec.CleanArchitecture.Domain.ToDoListAggregate.Entities.ToDoList", "List")
                        .WithMany("ToDoItems")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("List");
                });

            modelBuilder.Entity("Xivotec.CleanArchitecture.Domain.ToDoListAggregate.Entities.ToDoList", b =>
                {
                    b.Navigation("ToDoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
