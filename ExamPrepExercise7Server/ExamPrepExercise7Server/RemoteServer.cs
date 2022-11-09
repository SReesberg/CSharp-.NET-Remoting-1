using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;                 //REMEMBER THE DEBUG/BIN REMOTABLE OBJECT REFERENCE
using System.Runtime.Remoting.Channels.Tcp;           //REMEMBER THESE MY GUY - TCP OR HTTP
using ExamPrepExercise7RemotableObject;


namespace ExamPrepExercise7Server
{
    class RemoteServer
    {
        static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel(8081);
            ChannelServices.RegisterChannel(chan, true);

            RemotingConfiguration.RegisterWellKnownServiceType(System.Type.GetType("ExamPrepExercise7RemotableObject.myRemoteClass, ExamPrepExercise7RemotableObject"),"RemoteTest",WellKnownObjectMode.SingleCall);

            Console.WriteLine("Server has started in SingleCall mode on port 8081...");
            Console.WriteLine("Press <ENTER> to terminate the server...");
            Console.ReadLine();


           
        }
        
       
    }
}
