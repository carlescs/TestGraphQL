using Microsoft.EntityFrameworkCore;
using System;
using TestGraphQL.Data;
using TestGraphQL.Database;
using TestGraphQL.Mutations;
using TestGraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite("Data Source=books.db");
});
builder.Services.AddScoped<IBookRepository,BookRepository>(); 
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddTypeExtension<BookQueries>()
    .AddMutationType<Mutation>()
    .AddTypeExtension<BookMutations>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
