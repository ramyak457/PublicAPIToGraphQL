using GraphQL.Types;
using VaccinationAPI.ViewModels.Holidays;

namespace PublicAPIToGraphQL.Schemas.Holiday
{
    public class ProvinceInfoType : ObjectGraphType<ProvinceInfo>
    {
        public ProvinceInfoType() 
        {
            Field(x => x.ID).Description("Primary key for a holiday.");
            Field(x => x.NameEn).Description("English name.");
            Field(x => x.NameFr).Description("French name.");
            Field(x => x.SourceLink).Description("URL to public holidays reference for this region.");
            Field(x => x.SourceEn).Description("Name of reference page with public holidays for this region.");
        }
    }
}
