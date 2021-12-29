using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppBasicaMvc.Models
{
    public class Fornecedor : Entity
    {
  
        public string Nome { get; set; }


        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }

        /*1 fornecedor tem um endereco*/
        public Endereco Endereco { get; set; }

        public bool Ativo { get; set; }

        /* entity releations -  1 Fornecedor tem muitos Produtos*/
        public IEnumerable<Produto> produtos { get; set; }
    }
}
