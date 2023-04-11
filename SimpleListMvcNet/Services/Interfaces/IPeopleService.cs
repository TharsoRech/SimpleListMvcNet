using SimpleListMvcNet.Models.People;

namespace SimpleListMvcNet.Services.Interfaces
{
    public interface IPeopleService
    {
        Task<List<People>> GetPeople();
    }
}
