using ProjetoModeloDDD2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD2.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Preencha o nome")]
        [MaxLength(150, ErrorMessage = "Max {0} caracteres")]
        [MinLength(2, ErrorMessage = "Min {0} caracteres")]
        public string Nome { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","9999999")]
        [Required(ErrorMessage = "Preencha o valor")]
        public decimal Valor { get; set; }
        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}