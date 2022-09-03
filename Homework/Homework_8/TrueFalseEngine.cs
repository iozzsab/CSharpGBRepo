using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_8
{
    public class TrueFalseEngine
    {

        #region Private Fields
        /// <summary>
        /// Название файла
        /// </summary>
        string fileName;
        List<Question> list;
        public string FileName
        {
            set { fileName = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Записывает путь к файлу и инициализирует список вопросов
        /// </summary>
        /// <param name="fileName"></param>
        public TrueFalseEngine(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// Возврат размера списка вопросов
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }
        /// <summary>
        /// Доступ к закрытому объекту
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Question this[int index]
        {
            get { return list[index]; }
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Добавление вопроса
        /// </summary>
        /// <param name="text"></param>
        /// <param name="trueFalse"></param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        /// <summary>
        /// Удаление вопроса
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        /// <summary>
        /// Десерилизация списка вопросов
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
        }
       
        /// <summary>
        /// Серилизация списка вопросов
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, list);
            fileStream.Close();
        }


        #endregion
    }
}
