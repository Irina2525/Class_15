using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15
{
    /*
     метод void setStart(int x) - устанавливает начальное значение
     метод int getNext() - возвращает следующее число ряда
     метод void reset() - выполняет сброс к начальному значению
     */
    interface ISeries
    {
        void setStart(int x); //метод принимает аргумент х, ничего не возвращает:(например 10 и  шаг 2) 10+2=12, 12+2=14, 14+2=16 и т.д.
        int getNext(); //метод должен возвращать след. число, т.е. сколько шагов, сколько раз вызвали
        void reset(); // метод сбрасывает, т.е. шагали сколько в getNext() шагов и вернули стартовое число х
    }
    class ArithProgression : ISeries // класс реализует интерфейс ISeries
    {
        int step;  // шаг, задаем для него отдельный метод  public void setStep
        int startValue;  // стартовое значение
        int currentValue;  // текущее значение

        public int getNext()
        {
            currentValue += step; // к числу добавляет step, т.е. увеличиваем на шаг step
            return currentValue; // и возвращаем это число 

        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x; // в стартовое значение присваиваем х
            currentValue = startValue;
        }
        public void setStep(int s) // метод принимает s
        {
            step = s; // в переменную step заносит s
        }

    }


    class GeomProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;

        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }

}
