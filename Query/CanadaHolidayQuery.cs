using GraphQL;
using GraphQL.Types;
using PublicAPIToGraphQL.Schemas.Holiday;
using PublicAPIToGraphQL.Schemas.Population;
using VaccinationAPI;

namespace PublicAPIToGraphQL.Query
{
    public class CanadaHolidayQuery : ObjectGraphType
    {
        public CanadaHolidayQuery(CanadaHolidaysRepository canadaHolidaysRepository)
        {
            FieldAsync<CanadaHolidayType>(
         "holidayById",
         arguments: new QueryArguments(
             new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "holidayId" },
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "year" },
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "optional" }
         ),
         resolve: async context =>
         {
             var holidayId = context.GetArgument<int>("holidayId");
             var year = context.GetArgument<string>("year");
             var optional = context.GetArgument<string>("optional");

             return await canadaHolidaysRepository.GetHolidayById(holidayId, year, optional);
         }
        );

            FieldAsync<CanadaHolidayListType>(
                   "getholidays",
                    arguments: new QueryArguments(
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "year" },
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "federal" },
             new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "optional" }
             ),
               resolve: async context =>
               {
                   
                   var year = context.GetArgument<string>("year");
                   var federal = context.GetArgument<string>("federal");
                   var optional = context.GetArgument<string>("optional");

                   return await canadaHolidaysRepository.GetHoliday(year, federal, optional);
               }
            );
        }
    }
}
