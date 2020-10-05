using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OdontoCred.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(nullable: true),
                    CpfCliente = table.Column<string>(nullable: true),
                    EmailCliente = table.Column<string>(nullable: true),
                    CodigoConfirmacaoEmail = table.Column<string>(nullable: true),
                    CelularCliente = table.Column<string>(nullable: true),
                    CodigoConfirmacaoCelular = table.Column<string>(nullable: true),
                    DataConfirmacaoCelular = table.Column<DateTime>(nullable: true),
                    SenhaCliente = table.Column<string>(nullable: true),
                    CepResidencialCliente = table.Column<string>(nullable: true),
                    NumeroResidencialCliente = table.Column<string>(nullable: true),
                    ComplementoResidencialCliente = table.Column<string>(nullable: true),
                    ComprovanteEnderecoResidencial = table.Column<string>(nullable: true),
                    ComprovanteEndereco = table.Column<byte[]>(nullable: true),
                    CepComercialCliente = table.Column<string>(nullable: true),
                    NumeroComercialCliente = table.Column<string>(nullable: true),
                    ComplementoComercialCliente = table.Column<string>(nullable: true),
                    TelefoneComercialCliente = table.Column<string>(nullable: true),
                    CodigoBancoCliente = table.Column<int>(nullable: true),
                    AgenciaCliente = table.Column<string>(nullable: true),
                    ContaCliente = table.Column<string>(nullable: true),
                    TipoContaCliente = table.Column<int>(nullable: true),
                    RendaMensalCliente = table.Column<decimal>(nullable: true),
                    CodigoComprovacaoRendaCliente = table.Column<int>(nullable: true),
                    FotoCliente = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    FrenteDocumentoCliente = table.Column<byte[]>(nullable: true),
                    VersoDocumentoByte = table.Column<byte[]>(nullable: true),
                    VersoDocumentoCliente = table.Column<string>(nullable: true),
                    CodigoAtividadeCliente = table.Column<int>(nullable: true),
                    CargoCliente = table.Column<string>(nullable: true),
                    OutrasRendas = table.Column<string>(nullable: true),
                    ConfirmacaoEmailCliente = table.Column<string>(nullable: true),
                    DataNascimentoCliente = table.Column<DateTime>(nullable: true),
                    TelefoneResidencialCliente = table.Column<string>(nullable: true),
                    NomeMaeCliente = table.Column<string>(nullable: true),
                    EstadoResidencialCliente = table.Column<string>(nullable: true),
                    CidadeResidencialCliente = table.Column<string>(nullable: true),
                    EnderecoResidencialCliente = table.Column<string>(nullable: true),
                    DataEnvioEmailConfirmacaoCliente = table.Column<DateTime>(nullable: true),
                    Negativado = table.Column<bool>(nullable: false),
                    EstadoComercialCliente = table.Column<string>(nullable: true),
                    CidadeComercialCliente = table.Column<string>(nullable: true),
                    EnderecoComercialCliente = table.Column<string>(nullable: true),
                    CnpjcomercialCliente = table.Column<string>(nullable: true),
                    NomeEmpresaComercialCliente = table.Column<string>(nullable: true),
                    DataConfirmacaoCodigoEmailCliente = table.Column<DateTime>(nullable: true),
                    IdProfissao = table.Column<int>(nullable: true),
                    digitoAgenciaCliente = table.Column<string>(nullable: true),
                    digitoContaCliente = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    senha2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
