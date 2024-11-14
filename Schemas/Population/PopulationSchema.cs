using VaccinationAPI.Query;
using GraphQL.Types;

namespace PublicAPIToGraphQL.Schemas.Population
{
    public class PopulationSchema : Schema
    {
        public PopulationSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<PopulationQuery>();
        }
    }
}
