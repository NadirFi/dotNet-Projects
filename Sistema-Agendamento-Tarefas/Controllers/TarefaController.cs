using Microsoft.EntityFrameworkCore;
using Sistema_Agendamento_Tarefas.Context;
using Sistema_Agendamento_Tarefas.Models;

namespace Sistema_Agendamento_Tarefas.Controllers
{
    public static class TarefaController
    {
        public static void TarefasControllers (this WebApplication app)
        {

            var route = app.MapGroup("tarefa");

            //POST Tarefa
            route.MapPost("", async (TarefaRequest req, TarefasContext context) => 
                {
                // Verificando se os campos da requisição são nulos ou inválidos
                if (string.IsNullOrEmpty(req.titulo)) return Results.BadRequest(new { Error = "O título não pode ser nulo ou vazio." });
                
                if (string.IsNullOrEmpty(req.descricao)) return Results.BadRequest(new { Error = "A descrição não pode ser nula ou vazia." });

                if (req.data == DateTime.MinValue) return Results.BadRequest(new { Error = "Valor Invalido para Data" });

                if (!Enum.IsDefined(typeof(EnumStatus), req.status)) return Results.BadRequest(new { Error = "O status é inválido." });

                var tarefa = new TarefaModel(req.titulo, req.descricao, req.data, req.status);
                await context.AddAsync(tarefa);
                await context.SaveChangesAsync();

                return Results.Ok(new { tarefa, Message = "Tarefa criada com sucesso!" });
            });
            
            //GET for ALL Tarefas;
            route.MapGet("", async (TarefasContext context) => 
            {
                var tarefas = await context.AgendaTarefas.ToListAsync();
                return Results.Ok(tarefas);
            });

            //GET for ID;
            route.MapGet("{id:int}", async (int id, TarefasContext context) => 
            {
                var tarefa = await context.AgendaTarefas.FirstOrDefaultAsync(x => x.Id == id);
                
                if (tarefa == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(tarefa);
            });

            //GET for Titulo
            route.MapGet("Titulo/{titulo}", async (string titulo, TarefasContext context) => 
            {
                var tarefa = await context.AgendaTarefas.Where(x => x.Titulo.Contains(titulo)).ToListAsync();
                
                if (tarefa == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(tarefa);
            });

            //GET for Date
            route.MapGet("Data/{data}", async (DateTime data,TarefasContext context) => 
            {
                var tarefa = await context.AgendaTarefas.Where(x => x.Data.Date == data.Date).ToListAsync();
                
                if (tarefa == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(tarefa);
            });

            //GET for Status
            route.MapGet("Status/{status}", async (EnumStatus status, TarefasContext context) => 
            {
                var tarefa = await context.AgendaTarefas.Where(x => x.Status == status).ToListAsync();
                return Results.Ok(tarefa);
            });

            route.MapPut("{id:int}", async (int id, TarefaRequest req, TarefasContext context) => 
            {
                var tarefa = await context.AgendaTarefas.FirstOrDefaultAsync(x => x.Id == id);

                if (tarefa == null)
                {
                    return Results.NotFound();
                }

                tarefa.Titulo = req.titulo;
                tarefa.Data = req.data;
                tarefa.Descricao = req.descricao;
                tarefa.Status = req.status;

                await context.SaveChangesAsync();

                return Results.Ok(new { tarefa, Message = "Tarefa Atuaizada com sucesso!" });

            });
            

            //Remover Tarefa
            route.MapDelete("{id:int}", async (int id, TarefasContext context) => 
            {
                var tarefa = await context.AgendaTarefas.FirstOrDefaultAsync(x => x.Id == id);

                if (tarefa == null)
                {
                    return Results.NotFound();
                }
                context.Remove(tarefa);
                await context.SaveChangesAsync();

                return Results.Ok(tarefa);
            });
        } 
    }
}