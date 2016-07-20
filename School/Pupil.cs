using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Pupil
    {
        public virtual void Study() {
            Console.WriteLine("Pupil studies");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil reads");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil writes");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil relaxes");
        }

    }

    public class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent pupil studies");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent pupil reads");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil writes");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil relaxes");
        }
    }

    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil studies");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil reads");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil writes");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil relaxes");
        }
    }

    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil studies");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil reads");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil writes");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil relaxes");
        }
    }

}
