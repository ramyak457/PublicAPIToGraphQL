using GraphQL.Types;
using PublicAPIToGraphQL.Query;

namespace PublicAPIToGraphQL.Schemas
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<RootQuery>();
        }
    }
}
