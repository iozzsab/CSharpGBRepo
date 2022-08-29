/* 
 * Самойлов Оскар
 * 3. ** Переделать программу Пример использования коллекций для решения следующих задач:
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
 * в) отсортировать список по возрасту студента;
 * г) *отсортировать список по курсу и возрасту студента;
 * */

namespace Homework_6
{   
    /// <summary>
    /// Вспомогательный класс Student
    /// </summary>
    class Student
    {
        /// <summary>
        /// Обьявляем переменные для сортировки списка (количество переменных = количеству столбцов
        /// </summary>
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        /// <summary>
        /// Метод вспомогательного класса Student с информацией о студентах 
        /// </summary>
        /// <param name="firstName">Имя студента</param>
        /// <param name="lastName">Фамилия студента</param>
        /// <param name="university">Университет</param>
        /// <param name="faculty">Факультет</param>
        /// <param name="department">Направление(отделение)</param>
        /// <param name="age">Возраст студента</param>
        /// <param name="course">Номер курса</param>
        /// <param name="group">Номер группы</param>
        /// <param name="city">Горрод проживания</param>
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
}
