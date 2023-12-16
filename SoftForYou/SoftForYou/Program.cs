using Application.Name;
using Data;
using Data.Respository;
using Domain.ReturnedNames;
using Infrastructure.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(GenerateAndSaveNameCommandHandler));
builder.Services.AddSingleton<IReturnedNameRepository, ReturnedNameRepository>();

builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<INameRepository, NameRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
