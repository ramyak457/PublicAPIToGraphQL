using VaccinationAPI.ViewModels;

namespace VaccinationAPI.Services
{
    public interface IPopulationService
    {
        Task<PopulationObject> GetPopulation();
    }

}
