using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    [Serializable]
    public class Question
    {
        string text; //Вопрос
        bool trueFalse; //правильно/не_правильно

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Text { get { return text; } set { if (value.GetType() == typeof(string)) text = value; } }
        /// <summary>
        /// Ответ (да/нет)
        /// </summary>
        public bool TrueFalse { get { return trueFalse; } set { if (value.GetType() == typeof(bool)) trueFalse = value; } }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }

        public Question() { }

    }
}
