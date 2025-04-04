﻿// <auto-generated />
using System;
using Games.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hobby.Infraestructure.Migrations
{
    [DbContext(typeof(HobbyContext))]
    [Migration("20241106170818_Userpassword")]
    partial class Userpassword
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Games.Model.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_Developer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Created");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_Active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nm_Developer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Updated");

                    b.HasKey("Id")
                        .HasName("PK_Developer");

                    b.ToTable("Tb_Developer", (string)null);
                });

            modelBuilder.Entity("Games.Model.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_Game");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Created");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_Active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nm_Game");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Release");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Updated");

                    b.HasKey("Id")
                        .HasName("PK_Game");

                    b.ToTable("Tb_Game", (string)null);
                });

            modelBuilder.Entity("Games.Model.Plataform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_Plataform");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Created");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_Active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nm_Plataform");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Updated");

                    b.HasKey("Id")
                        .HasName("PK_Plataform");

                    b.ToTable("Tb_Plataform", (string)null);
                });

            modelBuilder.Entity("Games.Model.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_Publisher");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Created");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_Active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nm_Publisher");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Updated");

                    b.HasKey("Id")
                        .HasName("PK_Publisher");

                    b.ToTable("Tb_Publisher", (string)null);
                });

            modelBuilder.Entity("Games.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_User");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Created");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_Active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nm_User");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nm_Nickname");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ds_Password");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dat_Updated");

                    b.HasKey("Id")
                        .HasName("PK_User");

                    b.ToTable("Tb_User", (string)null);
                });

            modelBuilder.Entity("Tb_GameDeveloper", b =>
                {
                    b.Property<int>("DeveloperListId")
                        .HasColumnType("integer");

                    b.Property<int>("GameListId")
                        .HasColumnType("integer");

                    b.HasKey("DeveloperListId", "GameListId");

                    b.HasIndex("GameListId");

                    b.ToTable("Tb_GameDeveloper");
                });

            modelBuilder.Entity("Tb_GamePlataform", b =>
                {
                    b.Property<int>("GameListId")
                        .HasColumnType("integer");

                    b.Property<int>("PlataformListId")
                        .HasColumnType("integer");

                    b.HasKey("GameListId", "PlataformListId");

                    b.HasIndex("PlataformListId");

                    b.ToTable("Tb_GamePlataform");
                });

            modelBuilder.Entity("Tb_GamePublisher", b =>
                {
                    b.Property<int>("GameListId")
                        .HasColumnType("integer");

                    b.Property<int>("PublisherListId")
                        .HasColumnType("integer");

                    b.HasKey("GameListId", "PublisherListId");

                    b.HasIndex("PublisherListId");

                    b.ToTable("Tb_GamePublisher");
                });

            modelBuilder.Entity("Tb_UserGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("GameId")
                        .HasColumnType("integer");

                    b.Property<bool>("HasBeaten")
                        .HasColumnType("boolean")
                        .HasColumnName("has_Beaten");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Tb_UserGame");
                });

            modelBuilder.Entity("Tb_GameDeveloper", b =>
                {
                    b.HasOne("Games.Model.Developer", null)
                        .WithMany()
                        .HasForeignKey("DeveloperListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Games.Model.Game", null)
                        .WithMany()
                        .HasForeignKey("GameListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tb_GamePlataform", b =>
                {
                    b.HasOne("Games.Model.Game", null)
                        .WithMany()
                        .HasForeignKey("GameListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Games.Model.Plataform", null)
                        .WithMany()
                        .HasForeignKey("PlataformListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tb_GamePublisher", b =>
                {
                    b.HasOne("Games.Model.Game", null)
                        .WithMany()
                        .HasForeignKey("GameListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Games.Model.Publisher", null)
                        .WithMany()
                        .HasForeignKey("PublisherListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tb_UserGame", b =>
                {
                    b.HasOne("Games.Model.Game", "Game")
                        .WithMany("UserGameList")
                        .HasForeignKey("GameId");

                    b.HasOne("Games.Model.User", "User")
                        .WithMany("UserGameList")
                        .HasForeignKey("UserId");

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Games.Model.Game", b =>
                {
                    b.Navigation("UserGameList");
                });

            modelBuilder.Entity("Games.Model.User", b =>
                {
                    b.Navigation("UserGameList");
                });
#pragma warning restore 612, 618
        }
    }
}
