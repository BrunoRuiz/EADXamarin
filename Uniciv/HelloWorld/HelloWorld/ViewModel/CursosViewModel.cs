using HelloWorld.Model;
using System.Collections.Generic;

namespace HelloWorld.ViewModel
{
    public class CursosViewModel
    {
        public List<CursosModel> CursosDisponiveis { get; set; }
        public string InstituicaoNome { get; set; }
        public string InstituicaoEndereco { get; set; }

        public CursosViewModel()
        {
            InstituicaoNome = "UNICIV - Pós-Graduação EAD em TI";
            InstituicaoEndereco = "EDIFÍCIO TWIN TOWERS, Av. Tiradentes 501 – Jd Shangri-Lá A, Londrina/PR CEP 86070-545";
            CursosDisponiveis = new List<CursosModel>
            {
                new CursosModel {
                    Imagem = "https://uniciv.com.br/wp-content/uploads/2019/05/logo-uniciv.png",
                    Titulo = "EAD em Forense Computacional",
                    Descricao = @"  O curso de Perícia Forense Computacional se destina a identificar, preservar, recuperar analisar e apresentar fatos acerca de uma informação em meio digital. Apesar de frequentemente associada à investigação de crimes informáticos, a computação forense é também amplamente utilizada em processos civis.

  Entre seus objetivos primários, o curso de Perícia Forense Computacional busca qualificar profissionais de nível superior que atuam nas mais diversas áreas da computação a expandirem seu âmbito de atuação para investigar crimes digitais com rigor e metodologia científica.

  Os futuros profissionais serão capacitados nas mais avançadas técnicas de investigação forense sem abrir mão do amparo legal proporcionado pelas disciplinas com ênfase em direito.

Conteúdo Programático:

  •Tecnologias e Frameworks para forense computacional – 30 horas
  •Forense aplicada a dispositivos móveis – 30 horas
  •Análise Forense aplicada em sistemas Linux – 30 horas
  •Análise Forense aplicada a sistemas Windows – 30 horas
  •Criptografia e Criptoanálise, privacidade e comunicações digitais – 30 horas
  •Introdução a Segurança da Informação – 30 horas
  •Introdução à Engenharia Reversa – 30 horas
  •Exploração de Software – 30 horas
  •Introdução à Eletrônica e Hardware Hacking – 30 horas
  •Análise Forense Computacional – 30 horas
  •Gestão de Segurança da Informação – 30 horas
  •Noções de Direito para Segurança da Informação – 30 horas

TOTAL DA CARGA HORÁRIA – 360 h"
                },
                new CursosModel {
                    Titulo = "EAD em Business Intelligence",
                    Descricao = @"  Esta especialização em BI aborda tecnologias para extração, organização e consolidação de informações empresariais, minimizando riscos e oportunizando vantagens para a empresa por meio dos indicadores de sucesso/desempenho.

  Cada disciplina o profissional exercitará conceitos e práticas com o objetivo de identificar oportunidades de negócio por meio da análise de dados corporativos.

 

Conteúdo Programático:

  •Metodologias Ágeis – SCRUM / Kanban / XP / Lean – 30 horas
  •DataWarehouse / BigData – 30 horas
  •Business Intelligence – 30 horas
  •Modelagem e Projeto de Banco de Dados Relacionais – 30 horas
  •Arquitetura e Modelo de Dados Alternativos – NoSQL / Data Warehouse / Data Mining – 30 horas
  •Arquitetura de Cloud Computing – Azure – 30 horas
  •Inteligência Artificial – 30 horas
  •Business Analytics e Ferramentas Estratégicas – 30 horas
  •Computação para Ciência de Dados – 30 horas
  •Python aplicado – 30 horas
  •Estatística aplicada a ciência de dados – 30 horas
  •Aprendizagem de Máquina (Machine Learning) – 30 horas

TOTAL DA CARGA HORÁRIA – 360 h"
                },
                new CursosModel {
                    Imagem = "https://uniciv.com.br/wp-content/uploads/2019/05/logo-uniciv.png",
                    Titulo = "EAD em Internet das Coisas (IOT)",
                    Descricao = @"  O curso aborda questões técnicas e de soluções de negócios de forma integrada. Com ele você adquire a capacidade de atuar de forma estratégica e inovadora, identificar possibilidades de atuação no mercado, desenvolver a comunicação e ser agente transformador na área, seja do ponto de vista das tecnologias e/ou das tendências do mercado.

  As disciplinas oferecem ao profissional um currículo completo no âmbito do desenvolvimento de soluções para IOT, inter-relacionando conceitos e tecnologias de mercado, para o desenvolvimento de dispositivos conectados, serviços e aplicativos.

 

Conteúdo Programático:

  •Metodologias Ágeis – SCRUM / Kanban / XP / Lean – 30 horas
  •Automação e Robótica com Dispositivos Móveis (Arduino) – 30 horas
  •Engenharia de Usabilidade – 30 horas
  •Fundamentos de Redes de Computadores – 30 horas
  •Introdução à Eletrônica e Hardware Hacking – 30 horas
  •Inteligência Artificial – 30 horas
  •Arquitetura de Cloud Computing – Azure – 30 horas
  •Desenvolvimento para Android – 30 horas
  •Microcontroladores para IOT – 30 horas
  •Sensores e Atuadores em IOT – 30 horas
  •Sistemas Embarcados – 30 horas
  •Internet das Coisas: Arquitetura, Tecnologias e Aplicações – 30 horas

TOTAL DA CARGA HORÁRIA – 360 h"
                }
            };
        }
    }
}
