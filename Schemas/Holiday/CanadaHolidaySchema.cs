using GraphQL.Types;
using PublicAPIToGraphQL.Query;

namespace PublicAPIToGraphQL.Schemas.Holiday
{
    public class CanadaHolidaySchema : Schema
    {
        public CanadaHolidaySchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<CanadaHolidayQuery>();
        }
    }
}
