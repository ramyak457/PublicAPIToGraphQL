using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
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
builder.Services.AddSingleton<ISchema, PopulationSchema>();
builder.Services.AddGraphQL(options =>
{
    options.AddSystemTextJson();

});
//builder.Services.AddGraphQL(options => {
//    options.AddSystemTextJson();
//}).AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true);

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

app.UseGraphQLAltair();
app.UseGraphQL<ISchema>();


app.Run();

