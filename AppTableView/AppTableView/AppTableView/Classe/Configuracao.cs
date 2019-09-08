using System;
using System.Collections.Generic;
using System.Text;

namespace AppTableView.Classe
{
    public class Configuracao
    {
        public bool SyncAutomatico { get; set; }
        public string NomeArquivoBackup { get; set; }
        public bool NoficationEmail { get; set; }
        public bool NotificationPush { get; set; }
        public string Observacao { get; set; }

        public Configuracao()
        {
            NoficationEmail = false;
            NomeArquivoBackup = "ArquivoTeste";
            NotificationPush = true;
            Observacao = "Aplicativo de teste sobre TableView - Criando nossa tela de Configuração.";
            SyncAutomatico = true;
        }

    }
}
