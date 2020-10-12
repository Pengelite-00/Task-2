using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    public abstract class Item : Tile
    {
        public Item(int X, int Y, char symbol) : base(X, Y)      //Constructor Deriving Data from Tile Class
        {

        }

        public abstract override string ToString();
    }
}
