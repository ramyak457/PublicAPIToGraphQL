using GraphQL.Types;
using PublicAPIToGraphQL.Schemas.Holiday;
using VaccinationAPI.ViewModels.Provinces;

namespace PublicAPIToGraphQL.Schemas.Provinces
{
    public class CanadaProvincesListType: ObjectGraphType<CanadaProvincesList>
    {
        public CanadaProvincesListType()
        {
            Field<ListGraphType<ProvinceDataType>>(
               "provinces",
               resolve: context => context.Source.Provinces,
               description: "Get all provinces"
           );
        }
        
    }
}
