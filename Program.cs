using crud_dot_net.DatabaseContext;
using crud_dot_net.Registers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfrastructure(builder.Configuration)
    .AddApplication()
    .AddPresentation();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "Sample API"));
}

app.UseHttpsRedirection();
// app.UseInfrastructure();
app.UseAuthorization();
app.MapControllers();

app.Run();