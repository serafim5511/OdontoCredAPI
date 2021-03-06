﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OdontoCred.Models;

namespace OdontoCred.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200920205753_Implementarajsute")]
    partial class Implementarajsute
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OdontoCred.Models.CadastroCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgenciaCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BairroCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CargoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CelularCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("CepComercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CepResidencialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CidadeComercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CidadeResidencialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CnpjcomercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CodigoAtividadeCliente")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoBancoCliente")
                        .HasColumnType("int");

                    b.Property<int?>("CodigoComprovacaoRendaCliente")
                        .HasColumnType("int");

                    b.Property<string>("CodigoConfirmacaoCelular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoConfirmacaoEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplementoComercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplementoResidencialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ComprovanteEndereco")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ComprovanteEnderecoResidencial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmacaoEmailCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContaCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpfCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<DateTime?>("DataConfirmacaoCelular")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataConfirmacaoCodigoEmailCliente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataEnvioEmailConfirmacaoCliente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataNascimentoCliente")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("EnderecoComercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoResidencialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoUFCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoComercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoResidencialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FotoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FrenteDocumentoCliente")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("IdProfissao")
                        .HasColumnType("int");

                    b.Property<bool>("Negativado")
                        .HasColumnType("bit");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NomeEmpresaComercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMaeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroComercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroResidencialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutrasRendas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RendaMensalCliente")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenhaCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneComercialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneResidencialCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoContaCliente")
                        .HasColumnType("int");

                    b.Property<byte[]>("VersoDocumentoByte")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("VersoDocumentoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("digitoAgenciaCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("digitoContaCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
