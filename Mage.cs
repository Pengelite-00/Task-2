using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    public class Mage : Enemy
    {
        public Mage(int X, int Y, int enemydamage, int initialhp, int MaxHP, char symbol) : base(X, Y, 5, 5, 5, 'M')
        {

        }

        public override Movement ReturnMove(Movement move = 0)            //Movement Method for Mage
        {
            int random = rnd.Next(0, 1);
            {
                switch (random)
                {
                    case 1:
                    move = Movement.No_Movement;
                    break;
                }
                return move;
            }
        }
    }
}
