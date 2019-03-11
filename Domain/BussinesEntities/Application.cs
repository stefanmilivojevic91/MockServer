using System.Collections.Generic;

namespace Domain.BussinesEntities
{
    public class Application
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

        public IEnumerable<Route> Routes { get; set; }

        public Application()
        {
            Routes = new List<Route>();
        }
    }
}
