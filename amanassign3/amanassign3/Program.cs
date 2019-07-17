using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace amanassign3
{
    class Program
    {
        static void Main(string[] args)
        {

                //var tp = new TextProcessing();
                //tp.Run();
                new Blue().SayFavoriteFood(Red.FavoriteFood);
            }
        }

        class TextProcessing
        {
            public void Run()
            {
                Queue<string> TextFile1 = new Queue<string>();
                // Open the names file and access the data
                using (StreamReader file = new StreamReader("U:/Users/739680/C0739680as3/C0739680as3/TextFile1.txt"))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        TextFile1.Enqueue(ln);
                        Console.WriteLine(ln);
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                    //post condition of while is:
                    // wer now have a data member named names which is a queue!!!!!!
                    PlayingWithStack.Run(TextFile1);
                }
            }
        }

        class PlayingWithStack
        {
            public static void Run(Queue<string> tangerine)
            {

                Stack<string> TextFile1 = new Stack<string>();

                //how can i access the queue variables names here in this class??
                //iterate over the queue
                //get each element
                //push it into the stack
                foreach (var item in tangerine)
                {
                    TextFile1.Push(tangerine.Dequeue());

                }

            }
        }

        class WorkBench { }

        class Red
        {
            public static string FavoriteFood = "Carrots";
        }

        class Blue
        {
            public void SayFavoriteFood(String FavFood)
            {
                Console.WriteLine(Red.FavoriteFood);
            }
        }
    }