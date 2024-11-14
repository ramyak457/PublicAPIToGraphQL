using GraphQL;
using GraphQL.Types;
using PublicAPIToGraphQL.Schemas.Holiday;
using PublicAPIToGraphQL.Schemas.Provinces;
using VaccinationAPI;

namespace PublicAPIToGraphQL.Query
{
    public class ProvinceQuery: ObjectGraphType
    {
        public ProvinceQuery(ProvinceRepository provinceRepository)
        {
            FieldAsync<CanadaProvincesType>(
            "provinceById",
            arguments: new QueryArguments(
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "provinceId" },
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "year" },
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "optional" }
            ),
            resolve: async context =>
            {
             var provinceId = context.GetArgument<string>("provinceId");
             var year = context.GetArgument<string>("year");
             var optional = context.GetArgument<string>("optional");

             return await provinceRepository.GetProvinceById(provinceId, year, optional);
            }
            );

            FieldAsync<CanadaProvincesListType>(
                   "getprovinces",
                    arguments: new QueryArguments(
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "year" },
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "optional" }
             ),
               resolve: async context =>
               {

                   var year = context.GetArgument<string>("year");
                   var optional = context.GetArgument<string>("optional");

                   return await provinceRepository.GetAllProvinces(year, optional);
               }
            );
        }
    }
}
