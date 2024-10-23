using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_03_quiz_with_gui.Model
{
    internal class Question
    {
        public string Query { get; set; }

        public string CorrectAnswer { get; set; }
        public string[] IncorrectAnswers { get; set; }


        public Question(
            string query, 
            string correctAnswer, 
            string incorrectAnswer1, 
            string incorrectAnswer2, 
            string incorrectAnswer3
            )
        {
            Query = query;
            CorrectAnswer = correctAnswer;

            IncorrectAnswers = new string[3] { incorrectAnswer1, incorrectAnswer2, incorrectAnswer3 };
        }
    }
}
