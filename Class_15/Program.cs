using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Арифметическая прогрессия***");
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(10); // устанавливаем стартовое значение 
            arithProgression.setStep(2); // шаг
            Console.WriteLine(arithProgression.getNext()); // вывожим значение арифм. прогрессии метода getNext
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset(); // сброс
            Console.WriteLine("Сброс до начального значения:");
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());

            Console.WriteLine();
            Console.WriteLine("***Геометрическая прогрессия***");
            GeomProgression geom = new GeomProgression();
            geom.setStart(10);
            geom.setStep(2);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            geom.reset(); // сброс
            Console.WriteLine("Сброс до начального значения:");
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());


            Console.ReadKey();
        }
    }
}
