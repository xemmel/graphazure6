using bestilmere.common.azure.DI;
using graphazure6;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
        .AddBestilmereAzure()
        .AddControllers();

builder.Services
            .AddGraphQLServer()
            .AddQueryType<Query>()
            .AddFiltering()

            .AddType<ResourceGroupsQueryType>()
            .AddType<ResourceGroupsGraphType>()

            .AddType<ResourcesQueryType>()

            .AddType<ActivityLogQueryType>()

            .AddType<RoleDefinitionsQueryType>()


            ;
            
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

app.MapGraphQL();

app.Run();
