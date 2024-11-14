using GraphQL.Types;
using VaccinationAPI.ViewModels.Holidays;

namespace PublicAPIToGraphQL.Schemas.Holiday
{
    public class HolidayInfoType : ObjectGraphType<HolidayInfo>
    {
        public HolidayInfoType()
        {
            Field(x => x.ID).Description("Primary key for a holiday.");
            Field(x => x.Date).Description("ISO date: the literal date of the holiday.");
            Field(x => x.NameEn).Description("Name in English.");
            Field(x => x.NameFr).Description("Name in French.");
            Field(x => x.Federal).Description("Whether this holiday is observed by federally-regulated industries.");
            Field(x => x.ObservedDate).Description("ISO date: when this holiday is observed.");
            Field<ListGraphType<ProvinceInfoType>>(
                "provinces",
                resolve: context => context.Source.Provinces,
                description: "Whether this is a province-wide statutory holiday, or one that is optional for employers."
            );

        }
    }
}
