using GraphQL.Types;
using VaccinationAPI.ViewModels.Population;

namespace PublicAPIToGraphQL.Schemas.Population
{
    public class PopulationType : ObjectGraphType<PopulationInfo>
    {
        public PopulationType()
        {
            Field(x => x.StateName).Description("The name of the state.");
            Field(x => x.Total).Description("Total population.");
            Field(x => x.YoungGroup).Description("Population in age group 18 to 59.");
            Field(x => x.SeniorGroup).Description("Population in age group 60 and above.");
        }
    }
}
