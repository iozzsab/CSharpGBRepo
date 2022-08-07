/*
 * Самойлов Оскар
 * 5.
 * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
 * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 * */
using Homework.Utils;
using System;

namespace Homework_2
{
    internal class Task_5ab
    {
        public static void Main(string[] args)
        {
            Console.Title = "BMI";
            OutputHelpers.PrintInfo(2, 5);
            Console.WriteLine("Расчёт индекса массы тела");
            BMI();
            Console.ReadLine();
        }
        /// <summary>
        /// Расчёт ИМТ
        /// </summary>
        public static void BMI()
        {
            Console.Write("Укажите ваш вес в килограммах: ");
            string massString = Console.ReadLine();
            double mass = Convert.ToDouble(massString);

            Console.Write("Укажите ваш рост в сантиметрах: ");
            string heightSrting = Console.ReadLine();
            double height = Convert.ToDouble(heightSrting);
                                                         
            double bmi = mass / ((height * height) / 10000);
            
            Console.WriteLine($"\nВаш индекс массы тела равен: {bmi:F2}");
            
            ScoreBMI(bmi);
            RecommendationsBMI(bmi, mass, height);
        }

        /// <summary>
        /// Классификация ИМТ
        /// </summary>
        /// <param name="bmiUse">локальная переменная ИМТ, 1 символ после точки</param>
        /// <returns></returns>        
        static double ScoreBMI(double bmi)
        {
            if (bmi < 10)
                Console.WriteLine("\nВы перьевая подушка. \nВ следующий раз введите коректные данные.");

            if (bmi < 16 && bmi >= 10)
                Console.WriteLine("\nВыраженный дефицит массы тела");

            if (bmi > 16 && bmi < 18.5)
                Console.WriteLine("\nНедостаточная масса тела (дефицит)");
            
            if (bmi >= 18.5 && bmi <= 24.9)
                Console.WriteLine("\nНормальная масса тела");

            if (bmi > 24.9 && bmi <= 30)
                Console.WriteLine("\nИзбыточная масса тела");

            if (bmi > 30 && bmi <= 60)
                Console.WriteLine("\nОжирение");

            if (bmi > 60)
                Console.WriteLine("\nВы паровоз Big Boy\nСамый большой паровоз в мире, который производился серийно в 1941-1944.\nВ следующий раз введите коректные данные.");
            return bmi;
        }

        /// <summary>
        /// Рекомендации по контролю веса. Согласноно идеальному весу по формуле Брока.
        /// </summary>
        /// <param name="bmiUse">локальная переменная имт с 1 символом после точки</param>
        /// <param name="bmi">расчёт итм</param>
        /// <param name="mass">Возвращаемый параметр веса</param>
        /// <param name="height">Возвращаемый параметр роста</param>
        /// <returns></returns>
        public static double RecommendationsBMI(double bmi, double mass, double height)
        {
            if (bmi < 10)
                Console.WriteLine($"\nДля стабилизации веса вам необходимо набрать минимум {((height - 110) * 1.15) - mass} кг. Или смирится со статусом подушки.");

            if (bmi < 16 && bmi >= 10)
                Console.WriteLine($"\nДля стабилизации веса вам необходимо набрать минимум {((height - 110) * 1.15) - mass} кг.");

            if (bmi > 16 && bmi < 18.5)                                      
                Console.WriteLine($"\nДля стабилизации веса вам необходимо набрать минимум {((height - 110) * 1.15) - mass} кг.");

            if (bmi >= 18.5 && bmi <= 24.9)
                Console.WriteLine("\nУ вас идеальный вес. Корректировки не требуются");

            if (bmi > 24.9 && bmi <= 30)
                Console.WriteLine($"\nДля стабилизации нужно сбросить минимум {((height - 110) * 1.15) - mass} кг.");

            if (bmi > 30 && bmi <= 60)
                Console.WriteLine($"\nДля стабилизации нужно сбросить минимум {((height - 110) * 1.15) - mass} кг.");

            if (bmi > 60)
                Console.WriteLine($"\nДля стабилизации нужно сбросить минимум {((height - 110) * 1.15) - mass} кг. Или смирится со статусом паровоза.");

           return bmi; return mass; return height; 
        }
    }
}
