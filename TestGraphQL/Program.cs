using TestGraphQL.Data;
using TestGraphQL.Mutations;
using TestGraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IBookRepository,BookRepository>(); 
builder.Services.AddGraphQLServer()
    .AddQueryType<BookQueries>()
    .AddMutationType<BookMutations>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
