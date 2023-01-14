using atividade_api_web.Models;
using atividade_api_web.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

VeiculoRepositorio.Instancia().Lista.Add(new Veiculo { Id = 1, Nome = "Teste", Marca = "Teste",Descricao = "Teste", Modelo= "Teste", Ano = 123 });
VeiculoRepositorio.Instancia().Lista.Add(new Veiculo { Id = 2, Nome = "Teste", Marca = "Teste",Descricao = "Teste", Modelo= "Teste", Ano = 123 });
VeiculoRepositorio.Instancia().Lista.Add(new Veiculo { Id = 3, Nome = "Teste", Marca = "Teste",Descricao = "Teste", Modelo= "Teste", Ano = 123 });
VeiculoRepositorio.Instancia().Lista.Add(new Veiculo { Id = 4, Nome = "Teste", Marca = "Teste",Descricao = "Teste", Modelo= "Teste", Ano = 123 });

app.Run();
