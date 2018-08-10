﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD2.Domain.Entities
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {

            return Ativo && DateTime.Now.Year-cliente.DataCadastro.Year >=5;
        }



    }
}
