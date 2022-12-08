using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerTest
{
    public class UserManager
    {
        public bool Add(string userId,string telephone, string email)
        {
            if (userId.Length < 3)
            {
                throw new System.Exception("UserId должен быть больше 2 символов!");
            }
            return true;
        }
    }
}
