using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Pilot_FreeJob.Models
{
    public class Categoria
{
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(10)]
        public String Descricao { get; set; }
        
        
    }
}
