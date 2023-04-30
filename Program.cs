using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace math_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = default;
            string name = default;
            int userScore = 0;
            int questionResult = 0;
            int highestScore = 0;
            byte userlevel = 1;
            byte answerCount = 5;
            byte levelScore = 0;
            byte levelPoint = 5;
            byte questionIndex = 0;


            Console.WriteLine("Pratik Matematik Uygulamasi");
            Console.WriteLine("******************************");
            Console.Write("Lutfen isminizi giriniz:");

            User user = new User(name, userScore, highestScore, userlevel, answerCount);
            Level level = new Level(userlevel, levelScore, levelPoint);

            userAnswer = user.registerControl();

            user.showUserInfos();

            while (userAnswer != "exit")
            {
                questionResult = level.createQuestion(user.userLevel, questionIndex);
                userAnswer = level.answerCheck();

                if (userAnswer == "exit")
                {
                    break;
                }
                else if (Convert.ToInt32(userAnswer) == questionResult)
                {
                    questionIndex++;
                    user.userScore = user.userScore + level.pointPerQuestion;
                    Console.WriteLine($"Dogru! puaniniz: {user.userScore}.");

                    if (user.userScore == 30)
                    {
                        user.userLevel = 2;
                        questionIndex = 0;
                        level.pointPerQuestion = 10;
                        Console.WriteLine($"\n{user.userLevel}. seviyeye ciktiniz!");
                        user.showUserInfos();
                    }
                    else if (user.userScore == 80)
                    {
                        user.userLevel = 3;
                        questionIndex = 0;
                        level.pointPerQuestion = 20;
                        Console.WriteLine($"\n{user.userLevel}. seviyeye ciktiniz!");
                        user.showUserInfos();
                    }


                }
                else if (Convert.ToInt32(userAnswer) != questionResult)
                {
                    questionIndex++;
                    user.userAnswerCount--;
                    Console.WriteLine($"Yanlis! Kalan cevap hakkiniz:{user.userAnswerCount}");

                    if (user.userAnswerCount == 0)
                    {
                        user.userHighestScore = user.calcHighestScore(user.userScore,user.userHighestScore);
                  
                        Console.WriteLine($"\nTum cevap haklariniz bitti! Rekorunuz: {user.userHighestScore}");
                        user.showUserInfos();
                        Console.WriteLine($"\nTekrar oynamak icin enter'a basiniz. Cikmak icin exit yaziniz:");
                        userAnswer = Console.ReadLine();
                        if (userAnswer != "")
                        {
                            Console.WriteLine("Cikis yapiliyor");
                            userAnswer = "exit";

                        }
                        else if (userAnswer == "")
                        {
                            user.userAnswerCount = 5;
                            user.userScore = 0;
                            user.userLevel = 1;
                            questionIndex = 0;
                            level.pointPerQuestion = 5;

                        }
                        else
                        {
                            break;
                        }

                    }

                }
            }
        }
    }
}
