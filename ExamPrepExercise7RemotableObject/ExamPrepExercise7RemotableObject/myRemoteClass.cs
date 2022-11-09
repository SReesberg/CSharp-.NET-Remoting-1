using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepExercise7RemotableObject
{
    public class myRemoteClass: MarshalByRefObject
    {
        public myRemoteClass()
        {

        }
        public string Greet(string username)
        {
            string greeting = "Greetings, Agent " + username;
            return greeting;
        }

        public ArrayList Generate()
        {
            ArrayList digits = new ArrayList();
            Random r = new Random();

            for (int i = 0; i < 13; i++)
            {
                int gen = r.Next(0, 9);
                digits.Add(gen);
            }

            return digits;
        }
    }
}
