using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace math_app
{
    public class User
    {
        public string userName;
        public int userScore;
        public int userHighestScore;
        public byte userLevel;
        public byte userAnswerCount;

    public User(string name, int score, int highestScore, byte level, byte answerCount)
        {
            this.userName = name;
            this.userScore = score;
            this.userHighestScore = highestScore;
            this.userLevel = level;
            this.userAnswerCount = answerCount;
        }
        public void showUserInfos()
        {


            Console.WriteLine("\n******************************");
            Console.WriteLine($"Isim: {userName} \nPuan:{userScore} \nSeviye:{userLevel} \nRekor:{userHighestScore} \nCevap Hakkı:{userAnswerCount}");
            Console.WriteLine("\n******************************");
        }
        public string registerControl()
        {
            string userAnswer;
            do
            {
                userAnswer = Console.ReadLine();
                if (userAnswer =="" || userAnswer == " ")
                {
                    Console.WriteLine("Isim alani bos birakilamaz.");
                }else if (userAnswer !="")
                {
                    this.userName = userAnswer;

                }
         
            } while ( userAnswer =="" || userAnswer==" ");


            return userAnswer;
        }
        public int calcHighestScore(int userScore,int userHighestScore)
        {
            if (userScore > userHighestScore)
            {
                userHighestScore =userScore;
            }

            return userHighestScore;
        }
    }
}
