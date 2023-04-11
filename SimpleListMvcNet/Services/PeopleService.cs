using SimpleListMvcNet.Models.People;
using SimpleListMvcNet.Services.Interfaces;

namespace SimpleListMvcNet.Services
{
    public class PeopleService : IPeopleService
    {
        public async Task<List<People>> GetPeople()
        {
            //Iplementation with BackEnd,just the mock here
            List<People> people = new List<People>();

            for (int i = 0; i < 20; i++)
            {
                var p = new People
                {
                    Name = i.ToString(),
                    Id = i + 1,
                    DateOfBirth = DateTime.Now.AddDays(i),
                    Active = true
                };
                people.Add(p);
            }
            return people;
        }
    }
}
