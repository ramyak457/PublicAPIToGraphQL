using GraphQL.Types;
using VaccinationAPI.Controllers;
using VaccinationAPI.Schemas;
using VaccinationAPI.ViewModels;

namespace VaccinationAPI.Query
{
    public class PopulationQuery: ObjectGraphType
    {
        public PopulationQuery(PopulationRepository populationRepository) {
            Field<ListGraphType<PopulationType>>("Population", resolve: context => populationRepository.GetPopulation());
        }
    }
}
