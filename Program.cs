using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyReplaceLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            while (true)
            {
                Console.WriteLine("Input word:");
                string inputvalue = Console.ReadLine();
                if (inputvalue == "ex")
                {
                    break;
                }
                ArrayLetters arrayLetters = new ArrayLetters();
                arrayLetters.IndexArray(inputvalue);
                arrayLetters.OutputLetter();                
            }            
        }
    }
    class ArrayLetters
    {
        Char[] cardinalEngKey = {'Q','q','W','w','E','e','R','r','T','t','Y','y','U','u','I','i','O','o','P','p','{','[','}',']',
                                 'A','a','S','s','D','d','F','f','G','g','H','h','J','j','K','k','L','l',':',';','"','"',
                                 'Z','z','X','x','C','c','V','v','B','b','N','n','M','m','<',',','>','.','?','/',' ','!'};
        Char[] cardinalUkrKey = {'Й','й','Ц','ц','У','у','К','к','Е','е','Н','н','Г','г','Ш','ш','Щ','щ','З','з','Х','х','Ї','ї',
                                 'Ф','ф','І','і','В','в','А','а','П','п','Р','р','О','о','Л','л','Д','д','Ж','ж','Є','є',
                                 'Я','я','Ч','ч','С','с','М','м','И','и','Т','т','Ь','ь','Б','б','Ю','ю',',','.',' ','!'};
        List<string> newWord = new List<string>();
        int indexeng; 
        int indexukr;
        char engKey, ukrKey;
        public void IndexArray(string keyBoardLetter)
        {
           for (int i = 0; i < keyBoardLetter.Length; i++)
            {
                
                indexeng = Array.IndexOf(cardinalEngKey, Convert.ToChar(keyBoardLetter[i]));
                indexukr = Array.IndexOf(cardinalUkrKey, (keyBoardLetter[i]));
                if (indexeng == -1)
                {
                    ukrKey = cardinalEngKey[indexukr];
                    newWord.Add(Convert.ToString(ukrKey));
                }
                else
                {
                    engKey = cardinalUkrKey[indexeng];
                    newWord.Add(Convert.ToString(engKey));
                }
            }
            
            //Console.WriteLine("Eng {0} ,Ukr {1}", indexeng, indexukr);
        }
        public void OutputLetter()
        {
            foreach (string b in newWord)
            {
                Console.Write(b);
            }
            Console.WriteLine("\n");
        }

    }

}
