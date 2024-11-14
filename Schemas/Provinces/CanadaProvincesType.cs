using GraphQL.Types;
using PublicAPIToGraphQL.Schemas.Holiday;
using VaccinationAPI.ViewModels.Provinces;

namespace PublicAPIToGraphQL.Schemas.Provinces
{
    public class CanadaProvincesType: ObjectGraphType<CanadaProvinces>
    {
        public CanadaProvincesType() 
        {
            Field<ProvinceDataType>(
                "province",
                resolve: context => context.Source.Province,
                description: "Get province by Id"
            );

        }
    }
}
