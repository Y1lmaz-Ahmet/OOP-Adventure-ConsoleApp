using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Adventure.Src.Text
{
    public class English : Language
    {
        public English()
        {
            ChooseYourName = "Hello, what is your name?";
            DefaultName = "No Name";
            Welcome = "welcome {0} to your OOP Adventure!";
        }
    }
}
