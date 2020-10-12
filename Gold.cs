using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    public class Gold : Item
    {
        private int noGold;      //Declaration

        public int NoGold            //Gets and Sets
        {

            get { return NoGold; }
            set { NoGold = value; }
        }


        public Gold(int X, int Y, char symbol) : base(X, Y, 'G')          //Constructor for Gold Tiles
        {
            NoGold = rnd.Next(0, 6);
        }

        private Random rnd = new Random();

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
