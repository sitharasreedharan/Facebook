using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Facebook.Test
{
    [TestFixture]
    class SignUpTests:Base
    {
        [Test]
        public void ValidUserSignUp()
        {
            UserSignUp oSignUp = new UserSignUp();
            oSignUp.SignUp("Sit","Thara","tiuyiyiyyiuyu@gmail.com","Rr12345!","1-Jun-1986","female");
            
        }

        [Test]
        public void InValidUserSignUp()
        {
            UserSignUp oSignUp = new UserSignUp();
            oSignUp.SignUp("Sit", "Thara", "tiuyiyiyyiuyu@gmail.com", "Rr12345!", "1-Jun-1986", "female");

        }
    }
}
