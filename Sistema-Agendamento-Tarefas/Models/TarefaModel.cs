namespace Sistema_Agendamento_Tarefas.Models
{
    public class TarefaModel
    {
        public TarefaModel(string titulo, string descricao, DateTime data, EnumStatus status)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            Data = data;
            Status = status;
        }
        public int Id { get; init; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatus Status { get; set; }


    }
}