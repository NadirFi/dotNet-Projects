using Microsoft.EntityFrameworkCore;
using Sistema_Agendamento_Tarefas.Models;

namespace Sistema_Agendamento_Tarefas.Context
{
    public class TarefasContext : DbContext
    {
        public TarefasContext(DbContextOptions<TarefasContext> options) : base(options) {}
        
        public DbSet<TarefaModel> AgendaTarefas { get; set; } 
    }
}