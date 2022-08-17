/*
 * Самойлов Оскар
 * 1. а) Дописать класс для работы с одномерным массивом. 
 * Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
 * Создать свойство Sum, которое возвращает сумму элементов массива, 
 * метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
 * метод Multi, умножающий каждый элемент массива на определённое число, 
 * свойство MaxCount, возвращающее количество максимальных элементов.
 * б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
 */

namespace ArrayClassLib
{

    /// <summary>
    /// Класс для работы с одномерным массивом
    /// </summary>
    public class ArrayClass
    {
        int[] array; //обьявили массив

        /// <summary>
        ///  Конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="arraySize">Общий размер массива</param>
        /// <param name="initialValue">Начальное значение</param>
        /// <param name="stepValue">заданный шаг</param>
        public ArrayClass(int arraySize, int initialValue, int stepValue)
        {
            //int[] array;//???????
            array = new int[arraySize];
            array[0] = initialValue;
            for (int i = 1; i < arraySize; i++)
            {
                array[i] = array[i - 1] + stepValue;
            }
        }
        
        /// <summary>
        ///  Cвойство которое возвращает сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sumArray = 0;
                for (int i = 0; i < array.Length; i++)
                    sumArray += array[i];
                return sumArray;
            }
        }

        /// <summary>
        /// Метод возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений)
        /// </summary>
        public int Inverse
         {
             set
             { 
                 for (int i = 0; i < array.Length; i++)
                     array[i] = array[i] * -1;
            }
         } 
        
        /*public ArrayClass(int[] a)
        {
            this.array = a;
        }

        public ArrayClass Inverse()
        {
            int[] local = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                local[i] = -array[i];
            return new ArrayClass(local);
        }*/
        
        /// <summary>
        /// Метод умножающий каждый элемент массива на определённое число
        /// </summary>
        public int Multi
        {
            set
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = array[i] * value;
            }
        }
        

        /// <summary>
        /// Возвращает максимальный элемент массива (допустим их было бы больше чем одно)
        /// </summary>
        public int MaxElement
        {
            get
            {
                int maxElement = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > maxElement) maxElement = array[i];
                return maxElement; //)
            }
        }

        /// <summary>
        /// Возвращает количество максимальных элементов массива
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = MaxElement;
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == MaxElement) count++;
                return count; 
            }
        }

        /// <summary>
        /// Метод возвращающий массив в виде строки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = "";
            foreach (int v in array)
                str = str + v + " ";
            return str;
        }
    }

}
