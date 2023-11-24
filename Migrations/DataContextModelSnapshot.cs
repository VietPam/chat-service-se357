﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using chat_service_se357.Models;

#nullable disable

namespace chat_service_se357.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<long>("last_change")
                        .HasColumnType("bigint");

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

                    b.Property<long>("conversationsID")
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

                    b.Property<long>("time")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("conversationsID");

                    b.ToTable("tb_message");
                });

            modelBuilder.Entity("chat_service_se357.Models.SqlUser", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("text");

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

            modelBuilder.Entity("SqlConversationSqlUser", b =>
                {
                    b.Property<long>("conversationsID")
                        .HasColumnType("bigint");

                    b.Property<long>("usersID")
                        .HasColumnType("bigint");

                    b.HasKey("conversationsID", "usersID");

                    b.HasIndex("usersID");

                    b.ToTable("SqlConversationSqlUser");
                });

            modelBuilder.Entity("chat_service_se357.Models.SqlMessage", b =>
                {
                    b.HasOne("chat_service_se357.Models.SqlConversation", "conversations")
                        .WithMany("messages")
                        .HasForeignKey("conversationsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("conversations");
                });

            modelBuilder.Entity("SqlConversationSqlUser", b =>
                {
                    b.HasOne("chat_service_se357.Models.SqlConversation", null)
                        .WithMany()
                        .HasForeignKey("conversationsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("chat_service_se357.Models.SqlUser", null)
                        .WithMany()
                        .HasForeignKey("usersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("chat_service_se357.Models.SqlConversation", b =>
                {
                    b.Navigation("messages");
                });
#pragma warning restore 612, 618
        }
    }
}
