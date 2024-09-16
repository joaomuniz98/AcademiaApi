using Microsoft.OpenApi.Models;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionar o contexto do banco de dados
builder.Services.AddDbContext<AcademiaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionar suporte para controladores de API
builder.Services.AddControllers();

// Adicionar e configurar o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Academia API", Version = "v1" });
});

var app = builder.Build();

app.UseHttpsRedirection();

// Usar Swagger e Swagger UI
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Academia API V1");
});

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
