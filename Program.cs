using OOP_Adventure.Src;
using OOP_Adventure.Src.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Adventure
{
    internal class Program
    {
        static void Main()
        {
            Text.LoadLanguage(new English());
           


            Console.WriteLine(Text.Language.ChooseYourName);
            var name = Console.ReadLine();

            if (name == string.Empty)
                name = Text.Language.DefaultName;

            Player player = new Player(name);
            Console.WriteLine(Text.Language.Welcome,player.Name);
        }
    }
}
