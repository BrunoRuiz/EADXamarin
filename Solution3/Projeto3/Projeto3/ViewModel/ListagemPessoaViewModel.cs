using Projeto3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto3.ViewModel
{
    public class ListagemPessoaViewModel
    {
        public List<PessoaModel> Pessoas { get; set; }

        public ListagemPessoaViewModel()
        {
            Pessoas = new List<PessoaModel>
            {
                new PessoaModel
                {
                    Nome = "Bruno Ruiz",
                    Email = "brunoruiz07@gmail.com",
                    Cargo = "Desenvolvedor Mobile",
                    UrlPerfil = "https://img.ibxk.com.br/2017/06/22/22100428046161.jpg"
                },

                new PessoaModel
                {
                    Nome = "João Pedro",
                    Email = "joao.pedro@gmail.com",
                    Cargo = "Suporte",
                    UrlPerfil = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_pSeFyjHqSqLzM519DCh6f8m-KGk7uCRzvmoI-Q31rI2q5Cwi"
                },

                new PessoaModel
                {
                    Nome = "Maria Alice",
                    Email = "maria@gmail.com",
                    Cargo = "CEO",
                    UrlPerfil = "https://cdn.vivotech.com.br/vivo-tech/wp-content/uploads/2018/07/26070343/momo-vivo-tech-2.jpg"
                },
            };
        }
    }
}
