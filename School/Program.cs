using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    class Program
    {

        public ClassRoom FillTheClass() {

            return new ClassRoom(new ExcellentPupil(), new BadPupil());

        }
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GroupStudents()); ;

        } 
    }
}
