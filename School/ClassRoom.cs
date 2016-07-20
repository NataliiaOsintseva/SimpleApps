using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        static Random rnd = new Random();

        private static Pupil GetRandomPupil()
        {
            int i = rnd.Next(0, 2);
            switch (i)
            {
                case 0: return new ExcellentPupil();
                case 1: return new GoodPupil();
                default: return new BadPupil();
            }
            
        }

        private ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4) {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3) : this(p1, p2, p3, GetRandomPupil()) { }

        public ClassRoom(Pupil p1, Pupil p2) : this(p1, p2, GetRandomPupil(), GetRandomPupil()) { }
         
        public void Study()
        {
            foreach (Pupil p in pupils)
            {
                p.Study();
            }
        }

        public void Write()
        {
            foreach (Pupil p in pupils)
            {
                p.Write();
            }
        }

        public void Read()
        {
            foreach (Pupil p in pupils)
            {
                p.Read();
            }
        }

        public void Relax()
        {
            foreach (Pupil p in pupils)
            {
                p.Relax();
            }
        }

        public void GetCode()
        {
            foreach (Pupil p in pupils)
            {
                Console.WriteLine( p.GetHashCode());
            }
        }
    }
}
