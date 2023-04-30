using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_app
{
    public class Level
    {
        public byte level;//1, 2, 3
        public byte levelScore;//0, 30, 80
        public byte pointPerQuestion;//5, 10, 20


        public Level(byte level, byte score, byte point)
        {
            this.level = level;
            this.levelScore = score;
            this.pointPerQuestion = point;
        }
        public int[][] CreateNumbers(byte level)
        {
            int[][] questionsArray = new int[3][];
            switch (level)
            {
                case 1:
                    questionsArray[0] = new int[] { 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 1, 2 };
                    questionsArray[1] = new int[] { 10, 3, 7, 9, 21, -4, 35, 60, 24, -80, 16, 90 };
                    questionsArray[2] = new int[] { 3, 4, 17, 56, -60, 35, 47, 58, 69, 10, 30, 12 };
                    break;

                case 2:
                    questionsArray[0] = new int[] { 1, 3, 4, 2, 4, 1, 3, 2, 3, 4, 1, 2 };
                    questionsArray[1] = new int[] { 230, 500, 210, 853, -425, 513, 85, -92, 310, 930, 195, -80 };
                    questionsArray[2] = new int[] { 70, -15, 7, 95, 25, 250, 10, 100, 40, 30, 75, 170 };
                    break;

                case 3:
                    questionsArray[0] = new int[] { 4, 5, 3, 2, 5, 4, 3, 2, 1, 3, 5, 1, 2, 3, 4 };
                    questionsArray[1] = new int[] { 4200, 80, 64, -1405, 170, 330, 1200, 5100, 810, -5000, 86, -1250, 8930, 135, 460 };
                    questionsArray[2] = new int[] { -70, 24, 4, 305, 20, 6, 80, 400, 45, 25, 5, 450, 630, 24, 20 };
                    break;

                default:

                    break;
            }
            return questionsArray;
        }
        public int createQuestion(byte level, byte index)
        {
            int[][] numbers = CreateNumbers(level);
            int answer = default;

            switch (numbers[0][index])
            {
                case 1:
                    Console.Write($"{numbers[1][index]} + {numbers[2][index]} = ");
                    answer = numbers[1][index] + numbers[2][index];
                    break;

                case 2:
                    Console.Write($"{numbers[1][index]} - {numbers[2][index]} = ");
                    answer = numbers[1][index] - numbers[2][index];
                    break;

                case 3:
                    Console.Write($"{numbers[1][index]} * {numbers[2][index]} = ");
                    answer = numbers[1][index] * numbers[2][index];
                    break;

                case 4:
                    Console.Write($"{numbers[1][index]} / {numbers[2][index]} = ");
                    answer = numbers[1][index] / numbers[2][index];
                    break;

                case 5:
                    Console.Write($"{numbers[1][index]} % {numbers[2][index]} = ");
                    answer = numbers[1][index] % numbers[2][index];
                    break;
                default:
                    Console.WriteLine($"Bir seyler ters gitti :/");
                    break;
            }
            return answer;
        }
        public string answerCheck()
        {
            string answer = default;
            bool isParsed = false;
            int number = default;
            do
            {
                answer = Console.ReadLine();
                isParsed = int.TryParse(answer, out number);

                if (answer == " " || answer == "")
                {
                    Console.WriteLine("Lutfen sayisal deger girin, veya exit yazin!");
                   
                }else if (answer=="exit")
                {
                    break;
                }
                else if (!isParsed)
                {
                    Console.WriteLine("Lutfen sayi giriniz!");
                   
                }

            } while (answer == " " || !isParsed);

            return answer;
        }
        
    }
}
