using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Pilot_FreeJob.Models
{
    public class Servico
{
    [Key]
    public int ServicoId { get; set; }
    [Required]
    [StringLength(10)]
    public String Descricao { get; set; }


    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }
    
    }
}
