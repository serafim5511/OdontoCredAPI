using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OdontoCred.Migrations
{
    public partial class Implementarteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgenciaCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "BairroCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CargoCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CelularCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CepComercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CepResidencialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CidadeComercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CidadeResidencialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CnpjcomercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CodigoAtividadeCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CodigoBancoCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CodigoComprovacaoRendaCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CodigoConfirmacaoCelular",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CodigoConfirmacaoEmail",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ComplementoComercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ComplementoResidencialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ComprovanteEndereco",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ComprovanteEnderecoResidencial",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ConfirmacaoEmailCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ContaCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CpfCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DataConfirmacaoCelular",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DataConfirmacaoCodigoEmailCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DataEnvioEmailConfirmacaoCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DataNascimentoCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EnderecoComercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EnderecoResidencialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EnderecoUFCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EstadoComercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EstadoResidencialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FotoCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FrenteDocumentoCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IdProfissao",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Negativado",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NomeEmpresaComercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NomeMaeCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NumeroComercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NumeroResidencialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "OutrasRendas",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RendaMensalCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TelefoneComercialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TelefoneResidencialCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoContaCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "VersoDocumentoByte",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "VersoDocumentoCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "digitoAgenciaCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "digitoContaCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "senha2",
                table: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "NomeCliente",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailCliente",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeCliente",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailCliente",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgenciaCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BairroCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CargoCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CelularCliente",
                table: "Clientes",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CepComercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CepResidencialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CidadeComercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CidadeResidencialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CnpjcomercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodigoAtividadeCliente",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodigoBancoCliente",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodigoComprovacaoRendaCliente",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoConfirmacaoCelular",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoConfirmacaoEmail",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComplementoComercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComplementoResidencialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ComprovanteEndereco",
                table: "Clientes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComprovanteEnderecoResidencial",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmacaoEmailCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContaCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpfCliente",
                table: "Clientes",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataConfirmacaoCelular",
                table: "Clientes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataConfirmacaoCodigoEmailCliente",
                table: "Clientes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEnvioEmailConfirmacaoCliente",
                table: "Clientes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimentoCliente",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EnderecoComercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoResidencialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoUFCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoComercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoResidencialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Clientes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FrenteDocumentoCliente",
                table: "Clientes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProfissao",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Negativado",
                table: "Clientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NomeEmpresaComercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeMaeCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroComercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroResidencialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutrasRendas",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RendaMensalCliente",
                table: "Clientes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefoneComercialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefoneResidencialCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoContaCliente",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "VersoDocumentoByte",
                table: "Clientes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VersoDocumentoCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "digitoAgenciaCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "digitoContaCliente",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "senha2",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
