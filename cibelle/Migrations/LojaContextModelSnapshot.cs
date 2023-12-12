﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cibelle.Context;

#nullable disable

namespace cibelle.Migrations
{
    [DbContext(typeof(LojaContext))]
    partial class LojaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("cibelle.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("cibelle.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdNotaDeVenda")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<int>("Percentual")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("cibelle.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("cibelle.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPagamento")
                        .HasColumnType("int");

                    b.Property<int>("IdTransportadora")
                        .HasColumnType("int");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int");

                    b.Property<bool>("Tipo")
                        .HasColumnType("bit");

                    b.Property<int?>("TipoDePagamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("TransportadoraId")
                        .HasColumnType("int");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TipoDePagamentoId");

                    b.HasIndex("TransportadoraId");

                    b.HasIndex("VendedorId");

                    b.ToTable("NotasDeVenda");
                });

            modelBuilder.Entity("cibelle.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdNotaDeVenda")
                        .HasColumnType("int");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("cibelle.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("cibelle.Models.TipoDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDoCobrado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposDePagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoDePagamento");
                });

            modelBuilder.Entity("cibelle.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transportadoras");
                });

            modelBuilder.Entity("cibelle.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("cibelle.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("cibelle.Models.TipoDePagamento");

                    b.Property<string>("Bandeira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDoCartao")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("cibelle.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("cibelle.Models.TipoDePagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("cibelle.Models.Item", b =>
                {
                    b.HasOne("cibelle.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Itens")
                        .HasForeignKey("NotaDeVendaId");

                    b.HasOne("cibelle.Models.Produto", "Produto")
                        .WithMany("Itens")
                        .HasForeignKey("ProdutoId");

                    b.Navigation("NotaDeVenda");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("cibelle.Models.NotaDeVenda", b =>
                {
                    b.HasOne("cibelle.Models.Cliente", "Cliente")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("ClienteId");

                    b.HasOne("cibelle.Models.TipoDePagamento", "TipoDePagamento")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("TipoDePagamentoId");

                    b.HasOne("cibelle.Models.Transportadora", "Transportadora")
                        .WithMany("NotasDeVenda")
                        .HasForeignKey("TransportadoraId");

                    b.HasOne("cibelle.Models.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId");

                    b.Navigation("Cliente");

                    b.Navigation("TipoDePagamento");

                    b.Navigation("Transportadora");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("cibelle.Models.Pagamento", b =>
                {
                    b.HasOne("cibelle.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Pagamentos")
                        .HasForeignKey("NotaDeVendaId");

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("cibelle.Models.Produto", b =>
                {
                    b.HasOne("cibelle.Models.Marca", "Marca")
                        .WithMany("Produtos")
                        .HasForeignKey("MarcaId");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("cibelle.Models.Cliente", b =>
                {
                    b.Navigation("NotasDeVenda");
                });

            modelBuilder.Entity("cibelle.Models.Marca", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("cibelle.Models.NotaDeVenda", b =>
                {
                    b.Navigation("Itens");

                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("cibelle.Models.Produto", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("cibelle.Models.TipoDePagamento", b =>
                {
                    b.Navigation("NotasDeVenda");
                });

            modelBuilder.Entity("cibelle.Models.Transportadora", b =>
                {
                    b.Navigation("NotasDeVenda");
                });
#pragma warning restore 612, 618
        }
    }
}
