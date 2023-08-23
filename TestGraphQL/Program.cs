using TestGraphQL.Data;
using TestGraphQL.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IBookRepository,BookRepository>(); 
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
