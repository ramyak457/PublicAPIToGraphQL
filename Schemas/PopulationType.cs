using GraphQL.Types;
using VaccinationAPI.ViewModels;

namespace VaccinationAPI.Schemas
{
    public class PopulationType: ObjectGraphType<Population>
    {
        public PopulationType()
        {
            Field(x => x.StateName);
            Field(x => x.Total);
            Field(x=> x.YoungGroup);
            Field(x=> x.SeniorGroup);
        }
    }
}
