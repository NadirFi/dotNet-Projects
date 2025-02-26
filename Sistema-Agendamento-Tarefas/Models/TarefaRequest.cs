namespace Sistema_Agendamento_Tarefas.Models
{
    public record TarefaRequest (string titulo, string descricao, DateTime data, EnumStatus status);
}