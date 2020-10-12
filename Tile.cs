using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{


    public abstract class Tile
    {
        protected int x;
        protected int y;                                        //Declarations

        public enum TileType { Hero, Enemy, Gold, Weapon }

        public Tile(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int X                                         //Gets and sets for dimensions
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public class Obstacle : Tile
        {
            public Obstacle(int X, int Y) : base(X, Y)
            {

            }
        }

        public class EmptyTile : Tile
        {
            public EmptyTile(int X, int Y) : base(X, Y)
            {

            }
        }
    }
}
