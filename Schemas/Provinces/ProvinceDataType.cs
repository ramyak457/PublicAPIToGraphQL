using GraphQL.Types;
using PublicAPIToGraphQL.Schemas.Holiday;
using VaccinationAPI.ViewModels.Provinces;

namespace PublicAPIToGraphQL.Schemas.Provinces
{
    public class ProvinceDataType : ObjectGraphType<ProvinceData>
    {
        public ProvinceDataType()   
        {
            Field(x => x.ID).Description("Primary key for a holiday.");
            Field(x => x.NameEn).Description("English name.");
            Field(x => x.NameFr).Description("French name.");
            Field(x => x.SourceLink).Description("URL to public holidays reference for this region.");
            Field(x => x.SourceEn).Description("Name of reference page with public holidays for this region.");
            Field<ListGraphType<ProvinceHolidaysType>>(
                "holidays",
                resolve: context => context.Source.Holidays,
                description: "Province Holidays"
            );
            Field<ProvinceHolidaysType>(
                "nextHoliday",
                resolve: context => context.Source.NextHoliday,
                description: "Next Province Holiday"
            );
        }
    }
}
