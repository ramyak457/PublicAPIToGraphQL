using GraphQL.Types;
using VaccinationAPI.Query;

namespace PublicAPIToGraphQL.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(CanadaHolidayQuery holidayQuery, PopulationQuery populationQuery, ProvinceQuery provinceQuery) 
        {
            AddField(holidayQuery.GetField("getholidays"));
            AddField(holidayQuery.GetField("holidayById"));
            AddField(populationQuery.GetField("population"));
            AddField(populationQuery.GetField("populationByState"));
            AddField(provinceQuery.GetField("provinceById"));
            AddField(provinceQuery.GetField("getprovinces"));
        }
    }
}
