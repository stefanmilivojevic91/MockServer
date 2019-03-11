using System.Collections.Generic;

namespace Domain.BussinesEntities
{
    public class User
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<Application> Applications;

        public User()
        {
            Applications = new List<Application>();
        }
    }
}
