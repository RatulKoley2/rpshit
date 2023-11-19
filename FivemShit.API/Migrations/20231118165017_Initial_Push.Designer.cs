﻿// <auto-generated />
using System;
using FivemShit.API.ContextClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FivemShit.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231118165017_Initial_Push")]
    partial class Initial_Push
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FivemShit.API.DataTables.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CartId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("DiscountPrice");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<int?>("MemberShipId")
                        .HasColumnType("int")
                        .HasColumnName("MemberShipId");

                    b.Property<decimal?>("MemberShipPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("MemberShipPrice");

                    b.Property<int?>("ScriptId")
                        .HasColumnType("int")
                        .HasColumnName("ScriptId");

                    b.Property<int?>("ScriptQuantity")
                        .HasColumnType("int")
                        .HasColumnName("ScriptQuantity");

                    b.Property<decimal?>("ScriptsTotalPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("ScriptsTotalPrice");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("TotalPrice");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("CartId");

                    b.HasIndex("MemberShipId");

                    b.HasIndex("ScriptId");

                    b.HasIndex("UserId");

                    b.HasIndex("CartId", "IsActive")
                        .IsUnique();

                    b.HasIndex("CartId", "MemberShipId", "IsActive")
                        .IsUnique()
                        .HasFilter("[MemberShipId] IS NOT NULL");

                    b.HasIndex("CartId", "ScriptId", "IsActive")
                        .IsUnique()
                        .HasFilter("[ScriptId] IS NOT NULL");

                    b.HasIndex("CartId", "UserId", "IsActive")
                        .IsUnique();

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Membership", b =>
                {
                    b.Property<int>("MemberShipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MemberShipId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberShipId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<decimal>("MemberShipPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("MemberShipPrice");

                    b.Property<string>("MembershipDescription")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MembershipDescription");

                    b.Property<string>("MembershipName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MembershipName");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Remarks");

                    b.HasKey("MemberShipId");

                    b.HasIndex("MemberShipId", "IsActive")
                        .IsUnique();

                    b.ToTable("Membership", (string)null);
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("OrderNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("OrderNo");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("OrderStatus");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("OrderTotal");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.HasIndex("OrderId", "IsActive")
                        .IsUnique();

                    b.HasIndex("OrderId", "UserId", "IsActive")
                        .IsUnique();

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("FivemShit.API.DataTables.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderDetailsId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailsId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("DiscountPrice");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<int?>("MemberShipId")
                        .HasColumnType("int")
                        .HasColumnName("MemberShipId");

                    b.Property<decimal?>("MemberShipPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("MemberShipPrice");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderId");

                    b.Property<int?>("ScriptId")
                        .HasColumnType("int")
                        .HasColumnName("ScriptId");

                    b.Property<int?>("ScriptQuantity")
                        .HasColumnType("int")
                        .HasColumnName("ScriptQuantity");

                    b.Property<decimal?>("ScriptsTotalPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("ScriptsTotalPrice");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("TotalPrice");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("MemberShipId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ScriptId");

                    b.HasIndex("OrderDetailsId", "IsActive")
                        .IsUnique();

                    b.HasIndex("OrderDetailsId", "MemberShipId", "IsActive")
                        .IsUnique()
                        .HasFilter("[MemberShipId] IS NOT NULL");

                    b.HasIndex("OrderDetailsId", "OrderId", "IsActive")
                        .IsUnique();

                    b.HasIndex("OrderDetailsId", "ScriptId", "IsActive")
                        .IsUnique()
                        .HasFilter("[ScriptId] IS NOT NULL");

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("RoleName");

                    b.HasKey("RoleId");

                    b.HasIndex("RoleId", "IsActive")
                        .IsUnique();

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Script", b =>
                {
                    b.Property<int>("ScriptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ScriptId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScriptId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime")
                        .HasColumnName("ExpiryDate");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Remarks");

                    b.Property<string>("ScriptDescription")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ScriptDescription");

                    b.Property<string>("ScriptName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ScriptName");

                    b.Property<decimal>("ScriptPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("ScriptPrice");

                    b.HasKey("ScriptId");

                    b.HasIndex("ScriptId", "IsActive")
                        .IsUnique();

                    b.ToTable("Script", (string)null);
                });

            modelBuilder.Entity("FivemShit.API.DataTables.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("DiscordUserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DiscordUserName");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.Property<string>("FivemUserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FivemUserName");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit")
                        .HasColumnName("IsBanned");

                    b.Property<bool>("IsMember")
                        .HasColumnType("bit")
                        .HasColumnName("IsMember");

                    b.Property<bool>("IsWhiteListed")
                        .HasColumnType("bit")
                        .HasColumnName("IsWhiteListed");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LastName");

                    b.Property<int>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("MemberId");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    b.Property<string>("ScriptsPurchased")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ScriptsPurchased");

                    b.HasKey("UserId");

                    b.HasIndex("MemberId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "IsActive")
                        .IsUnique();

                    b.HasIndex("UserId", "MemberId", "IsActive")
                        .IsUnique();

                    b.HasIndex("UserId", "RoleId", "IsActive")
                        .IsUnique();

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Cart", b =>
                {
                    b.HasOne("FivemShit.API.DataTables.Membership", "Memberships")
                        .WithMany("Carts")
                        .HasForeignKey("MemberShipId")
                        .HasConstraintName("FK_Carts_Membership");

                    b.HasOne("FivemShit.API.DataTables.Script", "Scripts")
                        .WithMany("Carts")
                        .HasForeignKey("ScriptId")
                        .HasConstraintName("FK_Carts_Scripts");

                    b.HasOne("FivemShit.API.DataTables.User", "Users")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Carts_Users");

                    b.Navigation("Memberships");

                    b.Navigation("Scripts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Order", b =>
                {
                    b.HasOne("FivemShit.API.DataTables.User", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_Users");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FivemShit.API.DataTables.OrderDetail", b =>
                {
                    b.HasOne("FivemShit.API.DataTables.Membership", "Memberships")
                        .WithMany("OrderDetails")
                        .HasForeignKey("MemberShipId")
                        .HasConstraintName("FK_OrderDetail_Membership");

                    b.HasOne("FivemShit.API.DataTables.Order", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetail_Order");

                    b.HasOne("FivemShit.API.DataTables.Script", "Scripts")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ScriptId")
                        .HasConstraintName("FK_OrderDetail_Scripts");

                    b.Navigation("Memberships");

                    b.Navigation("Orders");

                    b.Navigation("Scripts");
                });

            modelBuilder.Entity("FivemShit.API.DataTables.User", b =>
                {
                    b.HasOne("FivemShit.API.DataTables.Membership", "MemberShips")
                        .WithMany("Users")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Users_Memberships");

                    b.HasOne("FivemShit.API.DataTables.Role", "Roles")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Users_Roles");

                    b.Navigation("MemberShips");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Membership", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderDetails");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("FivemShit.API.DataTables.Script", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("FivemShit.API.DataTables.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
