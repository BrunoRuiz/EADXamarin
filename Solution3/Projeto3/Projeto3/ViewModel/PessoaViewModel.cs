using Projeto3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto3.ViewModel
{
    public class PessoaViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }


        public PessoaViewModel(PessoaModel pessoa)
        {
            this.Nome = pessoa.Nome;
            this.Email = pessoa.Email;
            this.Cargo = pessoa.Cargo;
        }
    }
}
