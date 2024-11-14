using GraphQL.Types;
using VaccinationAPI.ViewModels.Holidays;

namespace PublicAPIToGraphQL.Schemas.Holiday
{
    public class CanadaHolidayListType : ObjectGraphType<CanadaHolidaysList>
    {
        public CanadaHolidayListType() 
        {
            Field<ListGraphType<HolidayInfoType>>(
               "holidays",
               resolve: context => context.Source.Holiday,
               description: "Get all holidays"
           );
        }
    }
}
