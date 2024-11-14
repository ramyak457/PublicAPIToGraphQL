using GraphQL;
using GraphQL.Types;
using PublicAPIToGraphQL.Query;
using PublicAPIToGraphQL.Schemas.Holiday;
using PublicAPIToGraphQL.Schemas.Population;
using PublicAPIToGraphQL.Schemas.Provinces;
using VaccinationAPI;
using VaccinationAPI.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<PopulationType>();
builder.Services.AddSingleton<PopulationObjectType>();
builder.Services.AddTransient<PopulationRepository>();
builder.Services.AddSingleton<PopulationQuery>();
builder.Services.AddSingleton<ISchema, PopulationSchema>();
builder.Services.AddResponseCompression();

builder.Services.AddTransient<CanadaHolidaysRepository>();
builder.Services.AddSingleton<CanadaHolidayType>();
builder.Services.AddSingleton<CanadaHolidayListType>();
builder.Services.AddSingleton<HolidayInfoType>();
builder.Services.AddSingleton<ProvinceInfoType>();
builder.Services.AddSingleton<CanadaHolidayQuery>();
builder.Services.AddSingleton<ISchema, CanadaHolidaySchema>();


builder.Services.AddTransient<ProvinceRepository>();
builder.Services.AddSingleton<CanadaProvincesType>();
builder.Services.AddSingleton<CanadaProvincesListType>();
builder.Services.AddSingleton<ProvinceHolidaysType>();
builder.Services.AddSingleton<ProvinceDataType>();
builder.Services.AddSingleton<ProvinceQuery>();
builder.Services.AddSingleton<ISchema, ProvinceSchema>();

builder.Services.AddGraphQL(options =>
{
    options.AddSystemTextJson();

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseResponseCompression();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseGraphQLAltair();
app.UseGraphQL<ISchema>();


app.Run();

