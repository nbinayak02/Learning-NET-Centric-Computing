using System;
namespace AbstractAndInterface{
    interface Cylinders{
         void calcVolume();
         
    }

    public abstract class Hemisphere{
        abstract public void calcVolume();
    }

    public class CCalculation:Cylinders{
        double radius = 3.5;
        double height = 2.4;

       public void calcVolume(){
            double v = 3.14*radius*radius*height;
            Console.WriteLine("Volume of cylinder: {0}",v);
        }

    }

    public class HCalculation:Hemisphere{
        
        public override void calcVolume(){
            double radius = 4.6;
            double v = (2.0/3.0)*3.14*radius*radius*radius;
            Console.WriteLine("Volume of hemisphere: {0}",v);
        }
    }

    public class Program{
        public static void Main(){
            CCalculation c = new CCalculation();
            c.calcVolume();
            
            HCalculation h = new HCalculation();
            h.calcVolume();
        }
    }
}