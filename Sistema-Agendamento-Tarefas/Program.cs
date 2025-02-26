using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Sistema_Agendamento_Tarefas.Context;
using Sistema_Agendamento_Tarefas.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TarefasContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.TarefasControllers();
app.UseHttpsRedirection();

app.Run();