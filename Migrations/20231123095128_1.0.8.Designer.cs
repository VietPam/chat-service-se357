﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using chat_service_se357.Models;

#nullable disable

namespace chat_service_se357.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231123095128_1.0.8")]
    partial class _108
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("chat_service_se357.Models.SqlConversation", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("clientCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("shopCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("tb_conversation");
                });

            modelBuilder.Entity("chat_service_se357.Models.SqlMessage", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("conversationID")
                        .HasColumnType("bigint");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("receiverCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("senderCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("conversationID");

                    b.ToTable("tb_message");
                });

            modelBuilder.Entity("chat_service_se357.Models.SqlUser", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("is_shop")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("tb_user");
                });

            modelBuilder.Entity("chat_service_se357.Models.SqlMessage", b =>
                {
                    b.HasOne("chat_service_se357.Models.SqlConversation", "conversation")
                        .WithMany()
                        .HasForeignKey("conversationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("conversation");
                });
#pragma warning restore 612, 618
        }
    }
}
