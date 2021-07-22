using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class HarryIO
    {

        public static bool GetInt(out int number, string message, string error)
        {
            bool ret = false;
            Console.Write(message);
            while (int.TryParse(Console.ReadLine(), out number) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }
        public static bool GetInt(out int number, string message, string error, int max)
        {
            bool ret = false;
            Console.Write(message);
            while ((int.TryParse(Console.ReadLine(), out number) && number <= max) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }
        public static bool GetInt(out int number, string message, string error, int min, int max)
        {
            bool ret = false;
            number = -1;
            Console.Write(message);
            while ((int.TryParse(Console.ReadLine(), out number) && IsInRange(number, min, max)) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }


        public static bool GetFloat(out float number, string message, string error)
        {
            bool ret = false;
            Console.Write(message);
            while (float.TryParse(Console.ReadLine(), out number) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }
        public static bool GetFloat(out float number, string message, string error, float max)
        {
            bool ret = false;
            Console.Write(message);
            while ((float.TryParse(Console.ReadLine(), out number) && number <= max) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }
        public static bool GetFloat(out float number, string message, string error, float min, float max)
        {
            bool ret = false;
            number = -1;
            Console.Write(message);
            while ((float.TryParse(Console.ReadLine(), out number) && IsInRange(number, min, max)) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }


        public static bool GetDouble(out double number, string message, string error)
        {
            bool ret = false;
            Console.Write(message);
            while (double.TryParse(Console.ReadLine(), out number) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }
        public static bool GetDouble(out double number, string message, string error, double max)
        {
            bool ret = false;
            Console.Write(message);
            while ((double.TryParse(Console.ReadLine(), out number) && number <= max) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }
        public static bool GetDouble(out double number, string message, string error, double min, double max)
        {
            bool ret = false;
            number = -1;
            Console.Write(message);
            while ((double.TryParse(Console.ReadLine(), out number) && IsInRange(number, min, max)) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }


        public static bool GetChar(out char character, string message, string error)
        {
            bool ret = false;
            Console.Write(message);
            while (char.TryParse(Console.ReadLine(), out character) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }
        public static bool GetChar(out char character, string message, string error, string validationCharacters)
        {
            bool ret = false;
            Console.Write(message);
            while ((char.TryParse(Console.ReadLine(), out character) && CountCharApparitionsOnString(character,validationCharacters)>0) != true)
            {
                Console.Clear();
                Console.Write(error);
            }
            ret = true;
            Console.Clear();
            return ret;
        }


        public static bool GetString(out string text, string message)
        {
            bool ret = false;
            Console.Write(message);
            text = Console.ReadLine();
            ret = true;
            Console.Clear();
            return ret;
        }

        public static int CountCharApparitionsOnString(char character, string validationCharacters)
        {
            int ret = 0;
            foreach(char aux in validationCharacters)
            {
                if(aux == character)
                {
                    ret++;
                }
            }
            return ret;
        }

        public static bool IsInRange(int number, int min, int max)
        {
            bool ret = false;
            if (number >= min && number <= max)
            {
                ret = true;
            }
            return ret;
        }
        public static bool IsInRange(float number, float min, float max)
        {
            bool ret = false;
            if (number >= min && number <= max)
            {
                ret = true;
            }
            return ret;
        }
        public static bool IsInRange(double number, double min, double max)
        {
            bool ret = false;
            if (number >= min && number <= max)
            {
                ret = true;
            }
            return ret;
        }


        public static bool StandarizeName(ref string needToStandarize)
        {
            bool ret = false;
            needToStandarize = needToStandarize.ToLower();
            char[] auxVector = needToStandarize.ToCharArray();
            for(int i=0; i<auxVector.Length; i++)
            {
                if(i==0 || auxVector[i-1]==' ')
                {
                    auxVector[i] = char.ToUpper(auxVector[i]);
                }
            }
            needToStandarize = new string(auxVector);

            return ret;
        }

    }
}
