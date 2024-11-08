using GraphQL;
using GraphQL.Types;
using VaccinationAPI;
using VaccinationAPI.Query;
using VaccinationAPI.Schemas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<PopulationRepository>();
builder.Services.AddSingleton<PopulationType>();
builder.Services.AddSingleton<PopulationQuery>();
builder.Services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
builder.Services.AddSingleton<ISchema, PopulationSchema>();
builder.Services.AddGraphQL(opt => opt.AddSystemTextJson());

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
//app.MapGet("/api/pop1", ([FromServices] PopulationRepository productProvider) =>
//{
//    return productProvider.GetPopulation();
//})
.WithName("GetPopulation");
app.UseGraphQLAltair();
app.UseGraphQL<ISchema>();

app.Run();

