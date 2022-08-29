/* 
 * Самойлов Оскар
 * 3. ** Переделать программу Пример использования коллекций для решения следующих задач:
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
 * в) отсортировать список по возрасту студента;
 * г) *отсортировать список по курсу и возрасту студента;
 * */

using Homework.Utils;
using System; 
using System.Collections.Generic;
using System.IO;

namespace Homework_6
{
    internal class Task_3
    {
        public static void Main (string[] args)
        {
            Console.Title = "Student's";
            OutputHelpers.PrintInfo(6, 3);
            
            int magistr1 = 0; // Счетчик студентов - магистров первого года 
            int magistr2 = 0; // Счетчик студентов - магистров второго года
            int bakalavr = 0; // Счетчик студентов-бакалавров (1-4 курс)
            int courseCounter = 0; // Счетчик кол-ва студентов, учащихся на 5 и 6 курсах

            List<Student> list = new List<Student>(); //Список студентов

            DateTime dt = DateTime.Now;
            Dictionary<int, int> cousreFrequency = new Dictionary<int, int>();
            StreamReader sr = new StreamReader("..\\..\\students.csv"); //извлекаем таблицу
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    var student = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]);
                    list.Add(student);
                    // Одновременно подсчитываем количество магистров певрого и второго курсов
                    if (int.Parse(s[6]) == 5) magistr1++; 
                    else if (int.Parse(s[6]) == 6) magistr2++;

                    if (int.Parse(s[5]) > 17 && int.Parse(s[5]) < 21)
                    {
                        if (cousreFrequency.ContainsKey(int.Parse(s[6])))
                            cousreFrequency[int.Parse(s[6])] += 1;
                        else
                            cousreFrequency.Add(int.Parse(s[6]), 1);
                    }
                    // Количество студентов 5 и 6 курса (тоже самое но короче)
                    if (student.course == 5 || student.course == 6)
                        courseCounter++;
                    // Количетво бакалавров
                    if (student.course < 5)
                        bakalavr++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            Console.WriteLine("Общее количество студентов: " + list.Count);
            Console.WriteLine($"Магистров: {magistr1 + magistr2}");
            Console.WriteLine($"Бакалавров: {bakalavr}");
            Console.WriteLine($"Кол-во студентов, учащихся на 5 и 6 курсах: {courseCounter}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nПодсчёт количетва студентов в возрасте от 18 до 20 лет на каком курсе учатся.");
            Console.ResetColor();
            ICollection<int> keys = cousreFrequency.Keys;
            String result = String.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");
            foreach (int key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, cousreFrequency[key]);
            Console.WriteLine($"\n{result}");

            list.Sort(new Comparison<Student>(AgeCompare));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nСортировка студентов по возрасту: ");
            Console.ResetColor();
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

            list.Sort(new Comparison<Student>(CourceAndAgeCompare));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nСортировка студентов по курсу и возрасту: ");
            Console.ResetColor();
            foreach (var v in list) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");

            Console.WriteLine("");
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
        /// <summary>
        /// Метод сравнения экземпляров класса (возраст)
        /// </summary>
        /// <param name="student1">Студент 1</param>
        /// <param name="student2">Студент 2</param>
        /// <returns></returns>
        static int AgeCompare(Student student1, Student student2)          
        {
            return String.Compare(student1.age.ToString(), student2.age.ToString()); //сравнение строк
        }
        /// <summary>
        /// Метод сравнения экземпляров (возраст и курс)
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns></returns>
        static int CourceAndAgeCompare(Student student1, Student student2)
        {
            if (student1.course > student2.course)
                return 1;
            if (student1.course < student2.course)
                return -1;
            if (student1.age > student2.age)
                return 1;
            if (student1.age < student2.age)
                return -1;
            return 0;
        }
    }
}
