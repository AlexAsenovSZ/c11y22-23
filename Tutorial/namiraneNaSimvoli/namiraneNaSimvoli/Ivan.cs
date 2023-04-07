using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namiraneNaSimvoli
{
    class Ivan
    {
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
                    if (item ==' ')
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
