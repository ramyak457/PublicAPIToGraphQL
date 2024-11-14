using GraphQL.Types;
using PublicAPIToGraphQL.Query;

namespace PublicAPIToGraphQL.Schemas.Provinces
{
    public class ProvinceSchema: Schema
    {
        public ProvinceSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<ProvinceQuery>();
        }
    }
}
