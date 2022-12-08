
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace User
    {
        public class UserManager
        {
            public bool Add(string userId)
            {
                if (userId.Length < 3)
                {
                    throw new System.Exception("UserId должен быть больше 2 символов!");
                }
                return true;
            }
        }
    }