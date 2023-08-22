using OOP_Adventure.Src.Map;
using OOP_Adventure.Src.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Room
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    public Dictionary<Directions, int> Neighbors { get; set; } = new Dictionary<Directions, int>()
    {
        {Directions.North, -1},
        {Directions.East, -1},
        {Directions.South, -1},
        {Directions.West, -1},
        {Directions.None, -1},

    };
    public bool Visited { get; set; }
}

