using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Pilot_FreeJob.Models
{
    public class Usuario
{
        public int UsuarioId { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }

        public String RG { get; set; }

        public String CNH { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }

        public int Idade { get; set; }
        public String Telefone { get; set; }

        public String Endereco { get; set; }

        public String CEP { get; set; }

        public String Cidade { get; set; }

        public String Bairro { get; set; }
        public String Estado { get; set; }

        public String Email { get; set; }

        public String Login { get; set; }
        public String Senha { get; set; }
    }
}
