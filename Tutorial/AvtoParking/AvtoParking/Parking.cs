using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace AvtoParking
{


    class Parking
    {
        protected int[] position = new int[20];
        protected int freeTime = 1; //1h
        protected int priceTime = 2;
        public Parking()
        {
            this.ArrayZero();
        }
        public int Enter()
        {
            for (int i = 0; i > this.position.Length; i++)
            {
                if (this.position[i] != 1)
                {
                    position[i] = 1;
                    return i;
                }
            }
            return 0;
        }
        public void Exit()
        {

        }
        private void ArrayZero()
        {
            for (int i = 0; i < this.position.Length; i++)
            {
                this.position[i] = 0;
            }
        }

    }
}