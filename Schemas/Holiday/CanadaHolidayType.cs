using GraphQL.Types;
using VaccinationAPI.ViewModels.Holidays;

namespace PublicAPIToGraphQL.Schemas.Holiday
{
    public class CanadaHolidayType : ObjectGraphType<CanadaHolidays>
    {
        public CanadaHolidayType()
        {
            Field<HolidayInfoType>(
                "holiday",
                resolve: context => context.Source.Holiday,
                description: "Get a holiday by id"
            );
        }
        
    }
}
