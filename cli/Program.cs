using System;

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

    class CloudDeveloper : Developer {
        public string publiccloud = "abc cloud";
    }

    sealed class SealedClass  {
        public string inherit = "this class cant be inherited";
    }
}
