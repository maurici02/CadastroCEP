using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroCEP.Models
{
    public class Usuario{
        [Key]
        public int UsuarioID { get; set; }
        [Required(ErrorMessage ="Digite seu nome!")]
        public String Nome { get; set; }
        [Required(ErrorMessage ="Digite seu sobrenome!")]
        public String Sobrenome { get; set; }
        [Required(ErrorMessage ="Digite seu Email!")]
        public String Email { get; set; }
        [Required(ErrorMessage ="Digite sua senha!")]
        public String Senha { get; set; }
    }
}