using GraphQL.Types;
using VaccinationAPI.ViewModels.Population;

namespace PublicAPIToGraphQL.Schemas.Population
{
    public class PopulationObjectType : ObjectGraphType<PopulationObject>
    {
        public PopulationObjectType()
        {
            Field<PopulationType>(
                "modifiedData",
                resolve: context => context.Source.ModifiedData,
                description: "The modified population data."
            );
        }
    }
}
