using GraphQL;
using GraphQL.Types;
using VaccinationAPI.Controllers;
using VaccinationAPI.Schemas;
using VaccinationAPI.ViewModels;

namespace VaccinationAPI.Query
{
    public class PopulationQuery: ObjectGraphType
    {
        public PopulationQuery(PopulationRepository populationRepository)
        {
            FieldAsync<ListGraphType<PopulationType>>(
                "population",
                resolve: async context => await populationRepository.GetPopulation()
            );

            FieldAsync<ObjectGraphType<PopulationObject>>(
               "populationByState",
               arguments: new QueryArguments(new QueryArgument<StringGraphType>() { Name = "stateName" }),
               resolve: async context => {
                   string stateName = context.GetArgument<string>("stateName");
                   return await populationRepository.GetPopulationByState(stateName);
               }
           ); 
        }
    }
}
