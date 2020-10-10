using System;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace cli
{
    class Program
    {
        // class members / fields
        const int Readonly = 100;
        string status = "ready";

        public Program()
        {
            status = "constructed";
        }

        // is the given number a prime number? 
        bool PrimeNumber(int number) {
            int count = 0;
            for (int i = 1; i <= number; i++) {
                if (number % i == 0) {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count == 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime now = DateTime.Now;
            Console.WriteLine("now: " + now.ToString());

            int[] a = new int[10];
            a[5] = 100;
            int[] b = { 20, 30, 40 };

            foreach (int bb in b)
            {
                Console.WriteLine("b: " + bb);
            }

            Program program = new Program();
            Console.WriteLine("program status: " + program.status);
            Console.WriteLine("program readonly value: " + Program.Readonly);

            Developer dev = new Developer();
            dev.ProgrammingLanguage = "java";   // set
            Console.WriteLine("get property: " + dev.ProgrammingLanguage);
            dev.Experience = 10;
            Console.WriteLine("get property: " + dev.Experience);

            // Logging
            using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                // .AddFilter("Microsoft", LogLevel.Warning)
                // .AddFilter("System", LogLevel.Warning)
                .AddFilter("LoggingConsoleApp.Program", LogLevel.Information)
                .AddConsole();
        });
            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("Example log message");
            logger.LogDebug("debug example");
            logger.LogCritical("system shutdown in 3s...");
            logger.LogWarning("warning warning");
            logger.LogError("ERROR!");

            // JSON
            string jsonString;
            jsonString = JsonSerializer.Serialize(dev);
            logger.LogInformation(jsonString);

            Program app = new Program();
            logger.LogInformation("5 prime number? " + app.PrimeNumber(5));
        }
    }

    class Developer
    {
        // field 
        private string programmingLanguage;
        // property
        public string ProgrammingLanguage
        {
            get { return programmingLanguage; }
            set { programmingLanguage = value; }
        }

        // short hand (automatic property)
        public int Experience
        {
            get; set;
        }
    }

    class CloudDeveloper : Developer
    {
        public string publiccloud = "abc cloud";
    }

    sealed class SealedClass
    {
        public string inherit = "this class cant be inherited";
    }
}
