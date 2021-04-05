using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Class
{
    class Pet
    {
        private string name;
        private string type;
        private string age;

        public Pet(string name, string type, string age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }
        public string show()
        {
            return $" {this.name,-30} {this.type,30} {this.age,27}";
        }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static public Pet[] pets = new Pet[10];
        static public int count = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
