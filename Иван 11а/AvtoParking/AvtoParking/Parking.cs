using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace AvtoParking
{
    internal class Parking
    {
        protected int[] position = new int[20];
        protected int freeTime = 1; //1h
        protected int priceTime = 2;
        int counter;
        int[] queue = new int[1];
        int queueCounter;
        public void Enter()
        {
            for (int i = 0; i < position.Length; i++)
            {
                //position[i] = int.Parse(Console.ReadLine());
                if (position[i] == 0)
                {
                    //Console.WriteLine("Welcome!");
                    position[i] = 1;
                    return i;
                    break;
                }
                if (counter > 20)
                {
                    Console.WriteLine("The parking is full!");
                    Console.WriteLine("Please wait in the queue!");
                    queueCounter++;
                    queue = new int[queueCounter];
                    break;
                }
                else
                {
                    counter += position[i];
                }
            }

            
        }
        public void Exit()
        {
            counter--;

            if (counter < 20)
            {
                
            }
        }


    }
}
