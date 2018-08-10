using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD2.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteID { get; set; }
        [Required(ErrorMessage ="Preencha o nome")]
        [MaxLength(150, ErrorMessage ="Max {0} caracteres")]
        [MinLength(2,ErrorMessage = "Min {0} caracteres")]
        public string Nome { get; set; }



        [Required(ErrorMessage = "Preencha o sobrenome")]
        [MaxLength(150, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Preencha o email")]
        [MaxLength(150, ErrorMessage = "Max {0} caracteres")]
        [EmailAddress(ErrorMessage = "Utilize um email valido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}