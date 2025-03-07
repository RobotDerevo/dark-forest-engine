using System;
using System.IO;
using System.Text;
public class RunLocalHost
    {
    public static void Main(string[] args)
    {
        const string prefix = "/";
        string localname = "localhost";
        string servername = "Default Server";
        string serverip = "127.0.0.1";
        string[] soundtracks = { "test1", "test" };
        string[] commands = { "help", "usemap", "spawning" };
        int maxplayers = 10;
        int minplayers = 0;

        void Log(string msg)
        {
            string path = @"./log.txt";

            using (FileStream fs = File.OpenWrite(path))
            {
                Byte[] info =
                    new UTF8Encoding(true).GetBytes("" + msg);

                fs.Write(info, 0, info.Length);
            }

            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }
        void Engine()
        {
            float y;
            float x;
            int health;
            return;
        }

        void Update()
        {

        }

        void EngineWrite()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[ENGINE]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": ");
            return;
        }
        void TipWrite()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("[TIP]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": ");
            return;
        }
        void CfgWrite()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[CFG]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": ");
            return;
        }

        void WarnWrite()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[WARN]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": ");
            return;
        }

        void loadcommands()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                Console.Write(prefix + commands[i] + " ");
            }

        }

        if (localname == "localhost")
        {
            WarnWrite();
            Console.WriteLine("Loading LocalHost...");
        }
        else if (localname == "dedicatedserver")
        {
            WarnWrite();
            Console.WriteLine("Loading Dedicated server...");
        }
        else
        {
            WarnWrite();
            Console.WriteLine("Starting Client...");
        }

        if (servername != "" && localname == "client" || localname == "localhost")
        {
            WarnWrite();
            Console.WriteLine("Connecting to " + serverip);
            CfgWrite();
            Console.WriteLine("Min players: " + minplayers + " Max players: " + maxplayers);
            TipWrite();
            Console.WriteLine("To stop the server press any key");
        }

        EngineWrite();
        Console.WriteLine("Using Engine (build  1532)...");
        EngineWrite();
        Console.WriteLine("Using Vulkan 1.3 ...");
        WarnWrite();
        Console.Write("Loaded console commands: ");
        loadcommands();
        Console.ReadKey(true);
    }
}