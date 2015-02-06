using System;

namespace VolumeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a volume to convert!");
            double volume = Convert.ToDouble(Console.ReadLine());
            cubeVolume(volume);
            sphereVolume(volume);
            cylinderVolume(volume);
            coneVolume(volume);
            Console.ReadKey();
        }

        static void cubeVolume(double volume)
        {
            //Cube Volume = a^3
            double root = System.Math.Pow(volume, (1.0/3.0));
            Console.WriteLine("Cube: {0}m width, {0}m high, {0}m tall", string.Format("{0:0.00}", root));
        }

        static void sphereVolume(double volume)
        {
            //Sphere Volume = (4/3)*pi*r^3
            double r = System.Math.Pow(((volume * 0.75) / Math.PI), (1.0/3.0));
            Console.WriteLine("Sphere: {0}m radius", string.Format("{0:0.00}", r));
        }

        static void cylinderVolume(double volume)
        {
            //Cylinder Volume = pi*r^2*h
            //Assume r = 0.5*h
            double h = System.Math.Pow((4 * volume) / Math.PI, (1.0 / 3.0));
            double r = 0.5 * h;
            Console.WriteLine("Cylinder: {0}m tall, diameter of {1}m", string.Format("{0:0.00}", h), string.Format("{0:0.00}", (2 * r)));
        }

        static void coneVolume(double volume)
        {
            //Cone Volume = (1/3)*pi*r^2*h
            //Assume r = 0.5*h
            double h = System.Math.Pow((12 * volume) / Math.PI, (1.0 / 3.0));
            double r = 0.5 * h;
            Console.WriteLine("Cone: {0}m tall, {1}m radius", string.Format("{0:0.00}", h), string.Format("{0:0.00}", r));
        }
    }
}
