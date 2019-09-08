using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TODOList.Model
{
    [Table("TAREFA")]
    public class TarefaModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Finalizado { get; set; }
    }
}
