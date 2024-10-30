using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroCorretora.Model
{
    public class Corretor
    {

        [Key]
        [Required]
        public int idCorretor { get; set; }


        [Required]  
        public string nome { get; set; }

        public ICollection<CorretoraCadastro> CorretoraCadastro { get; set; }

    }
}
