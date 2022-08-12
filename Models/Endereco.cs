using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroCEP.Models
{
    public class Endereco{

        [Key]
        public int EnderecoID { get; set; }

        public String Cep { get; set; }

        public String Logradouro { get; set; }

        public String Bairro { get; set; }

        public String Localidade { get; set; }

    }
}
