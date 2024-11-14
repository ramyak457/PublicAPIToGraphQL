using GraphQL;
using GraphQL.Types;
using PublicAPIToGraphQL.Schemas.Population;
using VaccinationAPI.Controllers;
using VaccinationAPI.ViewModels;

namespace VaccinationAPI.Query
{
    public class PopulationQuery: ObjectGraphType
    {
        public PopulationQuery(PopulationRepository populationRepository)
        {
            FieldAsync<ListGraphType<PopulationType>>(
                Name = "population",
                resolve: async context => await populationRepository.GetPopulation()
            );

            FieldAsync<PopulationObjectType>(
            "populationByState",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "stateName" }),
            resolve: async context =>
            {
                var stateName = context.GetArgument<string>("stateName");
                return await populationRepository.GetPopulationByState(stateName);
            }
            );
        }
    }
}
