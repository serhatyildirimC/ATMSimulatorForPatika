using Data;
using Entities;

namespace Business
{
    public class AcountController
    {
        InMemory inMemory = new InMemory();
        public bool Controller(int id, string Password)
        {
            User user = inMemory.Get(id);

            if (user.Password == Password)
            {
                return true;
            }
            else return false;

        }

    }
}