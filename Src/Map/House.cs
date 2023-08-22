using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Adventure.Src.Map
{
    public partial class House
    {
        public Player Player { get; }

        private readonly Random _rnd = new Random(1234);

        public House(Player player)
        {
            Player = player;
        }
    }
}
