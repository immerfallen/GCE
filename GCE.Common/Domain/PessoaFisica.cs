using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCE.Common.Domain
{
    class PessoaFisica
    {

        public int Id { get; set; }

        public ClassificacaoPessoaEnum TipoPessoa { get; set; }

        public bool Nacional { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; }

        public bool Situacao { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string EstadoCivil { get; set; }

        public string Profissao { get; set; }        

        public string Fone1 { get; set; }

        public string Fone2 { get; set; }

        public string Fone3 { get; set; }

        public string TipoEmpresa { get; set; }

        public DateTime Nascimento { get; set; }

        public string Genero { get; set; }

        public string Nacionalidade { get; set; }
        
    }
}
