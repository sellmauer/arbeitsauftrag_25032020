using Quiz.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_25032020
{
    class Program
    {
        static void Main(string[] args)
        {
            Game spiel = new Game();

            Question austria = new Question("Wie viele Bundesländer hat Österreich?");
            austria.AddAnswer(new Answer("8"));
            austria.AddAnswer(new Answer("9", true));
            austria.AddAnswer(new Answer("10"));
            spiel.AddQuestion(austria);

            Question gitarre = new Question("Wie viele Saiten hat eine Gitarre?");
            gitarre.AddAnswer(new Answer("6", true));
            gitarre.AddAnswer(new Answer("4"));
            gitarre.AddAnswer(new Answer("5"));
            spiel.AddQuestion(gitarre);

            Question pferd = new Question("Wie lange ist ein Pferd trächtig?");
            pferd.AddAnswer(new Answer("10 Monate"));
            pferd.AddAnswer(new Answer("9 Monate"));
            pferd.AddAnswer(new Answer("11 Monate", true));
            spiel.AddQuestion(pferd);

            while (spiel.Status == GameStatus.Active)
            {
                var frage = spiel.NextQuestion;
                var antworten = frage.Answers;
            }



            


        }
    }
}
