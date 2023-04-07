using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namiraneNaSimvoli
{
    class Ivan
    {
        public double number;

        private void CmToInch()
        {
            this.number  /= 2.54;
            i++;
            i += 1
                    ++i 
        }

        public double FaceCube()
        {
            this.CmToInch();
            //int numberMethod = this.number;
            return this.number * this.number;
        }

        public void FaceCubeObj()
        {
            double numberConsole = double.Parse(Console.ReadLine());
            Ivan IvanObj = new Ivan();
            IvanObj.number = numberConsole;
            //int faceCube = IvanObj.FaceCube();
            Console.Write("Face Cube: ");
            Console.WriteLine(IvanObj.FaceCube());
        }

        public int lettersCount(string text)
        {
            int charCounter = 0;

            foreach (char letter in text)
            {

                if (letter != ' ')
                {
                    charCounter++;
                }
            }

            return charCounter;
        }

        public int wordsCounter(string text)
        {
            int wordCounter = 0;

            if (text != "" && text != " ")
            {
                wordCounter = 1;
                foreach (char item in text)
                {
                    if (item == ' ')
                    {
                        wordCounter++;
                    }
                }
            }

            return wordCounter;
        }

        public int points(string text, int expectedWordsCount, int expectedCharCount)
        {
            int charCounter = 0;
            int wordCounter = 0;
            int pointsCounter = 0;

            foreach (char letter in text)
            {

                if (letter != ' ')
                {
                    charCounter++;
                }
            }

            if (text != "" && text != " ")
            {
                wordCounter = 1;
                foreach (char item in text)
                {
                    if (item == ' ')
                    {
                        wordCounter++;
                    }
                }
            }

            if ((wordCounter < expectedWordsCount * 0.5) || (charCounter < expectedCharCount * 0.5))
            {
                pointsCounter += 0;
            }
            else if ((wordCounter >= expectedWordsCount * 0.5 && wordCounter <= expectedWordsCount * 0.75) || charCounter >= expectedCharCount * 0.5 && charCounter <= expectedCharCount * 0.75)
            {
                pointsCounter++;
            }
            else
            {
                pointsCounter += 2;
            }

            return pointsCounter;
        }
    }
}
