using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.SimkinOA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            

            
            if (value.Length == 0)
            {
                
                return false;
            }

            
            string russianLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            
            bool onlyRussianLetters = true;

            
            for (int i = 0; i < value.Length; i++)
            {
                char currentChar = value[i]; 

                if (russianLetters.IndexOf(currentChar) == -1)
                {
                    
                    onlyRussianLetters = false;
                    break;
                }
            }

            
            if (onlyRussianLetters)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}