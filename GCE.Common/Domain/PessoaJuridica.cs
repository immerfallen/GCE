using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCE.Common.Domain
{
    class PessoaJuridica
    {

        public int Id { get; set; }

        public ClassificacaoPessoaEnum TipoPessoa { get; set; }

        public bool Nacional { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; }

        public bool Situacao { get; set; }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public string TipoEmpresa { get; set; }

        public DateTime DataConstituicao { get; set; }

        public string Porte { get; set; }

        public string Fone1 { get; set; }

        public string Fone2 { get; set; }

        public string Fone3 { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string CaracterizacaoCapital { get; set; }

        public double QuantidadeQuota { get; set; }

        public double ValorQuota { get; set; }

        public double CapitalSocial { get; set; }
    }
}
