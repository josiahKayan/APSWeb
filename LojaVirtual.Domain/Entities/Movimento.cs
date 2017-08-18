using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Domain.Entities
{
    public class Movimento
    {
        public int MovimentoId { get; set; }
        public string Login { get; set; }
         
        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }

        public string Status { get; set; }
        public DateTime Data { get; set; }
    }
}
