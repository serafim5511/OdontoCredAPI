using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdontoCred.Models
{
    public class CadastroCliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite seu nome completo.")]
        [StringLength(100)]
        [Display(Name = "Nome Completo *")]

        public string NomeCliente { get; set; }
        [Required(ErrorMessage = "Digite seu CPF.")]
        [Display(Name = "CPF *")]
        [StringLength(13, ErrorMessage = "CPF invalido.")]
        public string CpfCliente { get; set; }
        [Required(ErrorMessage = "Digite seu E-mail.")]
        [EmailAddress]
        [StringLength(100)]
        [Display(Name = "E-mail *")]
        public string EmailCliente { get; set; }
        /*public string CodigoConfirmacaoEmail { get; set; }*/
        [Required(ErrorMessage = "Digite seu telefone.")]
        [Phone]
        [StringLength(14, ErrorMessage = "Numero invalido.")]
        [Display(Name = "Celular (00)90000-0000")]
        public string CelularCliente { get; set; }
        /*public string CodigoConfirmacaoCelular { get; set; }
        public DateTime? DataConfirmacaoCelular { get; set; }*/
        [Required(ErrorMessage = "Digite sua senha.")]
        public string SenhaCliente { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento")]
        public DateTime? DataNascimentoCliente { get; set; }
        /* public string CepResidencialCliente { get; set; }
         public string NumeroResidencialCliente { get; set; }
         public string ComplementoResidencialCliente { get; set; }
         public string ComprovanteEnderecoResidencial { get; set; }
         public byte[] ComprovanteEndereco { get; set; }
         public string CepComercialCliente { get; set; }
         public string NumeroComercialCliente { get; set; }
         public string ComplementoComercialCliente { get; set; }
         public string TelefoneComercialCliente { get; set; }
         public int? CodigoBancoCliente { get; set; }
         public string AgenciaCliente { get; set; }
         public string ContaCliente { get; set; }
         public int? TipoContaCliente { get; set; }
         public decimal? RendaMensalCliente { get; set; }
         public int? CodigoComprovacaoRendaCliente { get; set; }
         public string FotoCliente { get; set; }
         //[NotMapped]
         public byte[] Foto { get; set; }
         public byte[] FrenteDocumentoCliente { get; set; }
         //[NotMapped]
         public byte[] VersoDocumentoByte { get; set; }

         public string VersoDocumentoCliente { get; set; }
         public int? CodigoAtividadeCliente { get; set; }
         public string CargoCliente { get; set; }
         public string OutrasRendas { get; set; }
         public string ConfirmacaoEmailCliente { get; set; }
         [Required(ErrorMessage = "Digite sua data de nascimento.")]

         public string TelefoneResidencialCliente { get; set; }
         public string NomeMaeCliente { get; set; }
         public string EstadoResidencialCliente { get; set; }
         public string CidadeResidencialCliente { get; set; }
         public string EnderecoResidencialCliente { get; set; }
         public string EnderecoUFCliente { get; set; }
         public string BairroCliente { get; set; }
         public DateTime? DataEnvioEmailConfirmacaoCliente { get; set; }
         public bool Negativado { get; set; }
         public string EstadoComercialCliente { get; set; }
         public string CidadeComercialCliente { get; set; }
         public string EnderecoComercialCliente { get; set; }
         public string CnpjcomercialCliente { get; set; }
         public string NomeEmpresaComercialCliente { get; set; }
         public DateTime? DataConfirmacaoCodigoEmailCliente { get; set; }
         public int? IdProfissao { get; set; }

         public string digitoAgenciaCliente { get; set; }
         public string digitoContaCliente { get; set; }
         [Compare("SenhaCliente", ErrorMessage = "As senhas não conferem.")]
         public string Senha { get; set; }
         public string senha2 { get; set; }*/


    }
    public class LoginCliente
    {
        public string CPF { get; set; }
        public string Passawprd { get; set; }
    } 
}
