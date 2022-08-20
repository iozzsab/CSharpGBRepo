/*
 * Самойлов Оскар
 * 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
 * а) Вывести только те слова сообщения, которые содержат не более n букв.
 * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 * в) Найти самое длинное слово сообщения.
 * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 * д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 * */

using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    static class Message
    {
        static public string text;
        static Message()
        {
            #region Текст стихотворения
            text 
                = @"
         =======================
         Эдгар Аллан По — Ворон:
         =======================

=========================================================
 Как-то в полночь, в час угрюмый, утомившись от раздумий,
 Задремал я над страницей фолианта одного,
 И очнулся вдруг от звука, будто кто - то вдруг застукал,
 Будто глухо так затукал в двери дома моего.
 «Гость, — сказал я, — там стучится в двери дома моего,
 Гость — и больше ничего».

 Ах, я вспоминаю ясно, был тогда декабрь ненастный,
 И от каждой вспышки красной тень скользила на ковер.
 Ждал я дня из мрачной дали, тщетно ждал, чтоб книги дали
 Облегченье от печали по утраченной Линор,
 По святой, что там, в Эдеме ангелы зовут Линор,
 — Безыменной здесь с тех пор.
=========================================================";
            #endregion
        }
        /// <summary>
        /// Метод для вывода только тех слов сообщения, которые содержат не более n букв.
        /// </summary>
        static public void ShowWordsLength()
        {
            Console.Write("Введите максимальное количество букв в слове: ");
            int length = int.Parse(Console.ReadLine()); //задать количество букв слова
            
            string[] words = text.Split(new Char[] { ' ', ',', '.', '—', '=', ':', '«', '»' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= length)
                    Console.Write(word + " ");
            }
        }
        /// <summary>
        /// Метод для удаления из сообщения всех слов, которые заканчиваются на заданный символ.
        /// </summary>
        static public void DeleteWordsWithEndSymbol()
        {
            Console.Write("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.ReadLine();

            string[] words = text.Split(new Char[] { ' ', ',', '.', '—', '=', ':', '«', '»' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == symbol)
                {
                    text = text.Replace(word, "");
                }
            }   
            Console.WriteLine(text);
        }
        /// <summary>
        /// Метод поиска самого длинного слова в сообщении
        /// </summary>
        /// <returns>самое длинное слово</returns>
        static public string FindMaxLengthWord()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '—', '=', ':', '«', '»' });
            string maxWord = words[0];
            int maxLength = words[0].Length;
            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    maxWord = word;
                }
            }
            return maxWord;
        }
        /// <summary>
        ///  Метод формирующий строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        /// <returns></returns>
        static public StringBuilder StringOfLongWords()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '—', '=', ':', '«', '»' });
            StringBuilder result = new StringBuilder();
            int maxLenth = Message.FindMaxLengthWord().Length;
            foreach (string word in words)
            {
                if (word.Length == maxLenth)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            return result;
        }
        /// <summary>
        /// Метод, который производит частотный анализ текста
        /// </summary>
        /// <param name="words">массив слов</param>
        /// <param name="text">текст для анализа</param>
        static public void FrequencyAnalysis(string[] words, string text)
        {
            Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();
            string[] textWords = text.Split(new Char[] { ' ', ',', '.', '—', '=', ':', '«', '»' });
            foreach(string word in words)
            {
                foreach(string wordInText in textWords)
                {
                    if (word == "")
                        continue;
                    if (wordInText == word)
                    {
                        if (word == "")
                            continue;
                        if (wordsFrequency.ContainsKey(word))
                            wordsFrequency[word] += 1;
                        else
                            wordsFrequency.Add(word, 1);
                    }
                }
            }
            ICollection<string> keys = wordsFrequency.Keys;

            String result = String.Format("{0,-10} {1,-10}\n\n", "Слово", "Частота");

            foreach (string key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",key, wordsFrequency[key]);
            Console.WriteLine($"\n{result}");
        }
    }
}
