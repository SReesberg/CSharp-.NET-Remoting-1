using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using ExamPrepExercise7RemotableObject;

namespace ExamPrepExercise7Client
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            ExamPrepExercise7RemotableObject.myRemoteClass mrc;

            mrc = (ExamPrepExercise7RemotableObject.myRemoteClass)Activator.GetObject
                (typeof(ExamPrepExercise7RemotableObject.myRemoteClass), "tcp://localhost:8081/ExamPrepExercise7RemotableObject");

            mrc = new ExamPrepExercise7RemotableObject.myRemoteClass();

            Console.WriteLine("Please enter your name...");

            string name = Console.ReadLine();

            Console.WriteLine(mrc.Greet(name));

            string input = "";
            while (input != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("<g> Generate a 13 digit numeric code");
                Console.WriteLine("<e> Exit");
                Console.WriteLine("Input: ");

                string choice = Console.ReadLine();

                if (choice == "g")
                {
                    ArrayList numbers = mrc.Generate();
                    string code = "";
                    foreach (var item in numbers)
                    {
                        code = code + item;
                    }
                    Console.Clear();
                    Console.WriteLine("Your 13 digit code is: {0}", code);

                    
                }
                else if (choice == "e")
                {
                    input = "e";
                    Console.WriteLine("Press <ENTER> to terminate the program...");
                    Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("Please select <g> or <e>");
                }
            }
            







        }
    }
}
