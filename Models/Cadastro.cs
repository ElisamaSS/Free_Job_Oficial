using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Pilot_FreeJob.Models
{
    public class Cadastro
{
        public int ServicoId { get; set; }
        public int UsuarioId { get; set; }

        public int CategoriaId { get; set; }


        public Servico Servico { get; set; }
        public Categoria Categoria { get; set; }

        public Usuario Usuario { get; set; }

    }
}
