using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using TestGraphQL.Data;
using TestGraphQL.Database;
using TestGraphQL.Mutations;
using TestGraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (connectionString == null)
        options.UseSqlite("Data Source=books.db");
    else
        options.UseSqlServer(connectionString);
});
builder.Services.AddScoped<IBookRepository,BookRepository>()
    .AddScoped<IAuthorRepository,AuthorRepository>();
builder.Services.AddGraphQLServer()
    .RegisterDbContext<ApplicationDbContext>()
    .AddQueryType<Query>()
    .AddTypeExtension<BookQueries>()
    .AddTypeExtension<AuthorQueries>()
    .AddMutationType<Mutation>()
    .AddTypeExtension<BookMutations>();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
