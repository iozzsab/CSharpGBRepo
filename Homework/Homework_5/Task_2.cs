/*
 * Самойлов Оскар
 * 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
 * а) Вывести только те слова сообщения, которые содержат не более n букв.
 * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 * в) Найти самое длинное слово сообщения.
 * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 * д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 * */

using Homework.Utils;
using System;

namespace Homework_5
{
    internal class Task_2
    {
        public static void Main(string[] args)
        {
            Console.Title = "Message";
            OutputHelpers.PrintInfo(5, 2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Методы для обработки текста");
            Console.ResetColor();
            Console.WriteLine("Наш текст:\n" + Message.text);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n- Метод для вывода слов которые содержат не больше n букв");
            Console.ResetColor();
            Message.ShowWordsLength();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n- Метод для удаления слов заканчивающихся на определенный символ кириллицы");
            Console.ResetColor();
            Message.DeleteWordsWithEndSymbol();
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n- Метод для поиска саммого длиного слова текста");
            Console.ResetColor();
            Console.WriteLine("Самое длинное слово: "+ Message.FindMaxLengthWord());
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n- Сформированная строка с помощью StringBuilder из самых длинных слов сообщения: ");
            Console.ResetColor();
            Console.WriteLine(Message.StringOfLongWords());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n- ***Частоточный анализ текста:");
            Console.ResetColor();
            string[] arrayWords =
            {
                "Эдгар",
                "Ворон",
                "Будто",
                "Гость",
                "ясно"
            };
            Message.FrequencyAnalysis(arrayWords, Message.text);
            

            Console.ReadKey();
        }
    }
}
