using System;

namespace GeneratorDistanceOfTarget
{
    public class Distances
    {
        public static int GeneratorDistanceOfTarget(int min, int max)
        {
            if (min > max)
            {
                return -1;
            }

            Random random = new Random();

            /// REVIEW. a.boikov. 05/10/2024. Ограничения уже определены в рамках Next
            /// Метод не выдаст данных, выходящих за указанный диапазон гарантированно
            /// Цикл не нужен.

            int randomNumber = random.Next(min, max + 1);
            return randomNumber;
        }
    }
}
    /// REVIEW. a.boikov. 05/10/2024. В тестовых данных ожидаемых результатов
    /// явно ошибки. class Ballistic вынести в отдельный файл библиотеки классов
    
        /// REVIEW. a.boikov. 05/10/2024. добавить комментарий к переменным, что они значат
    
           

            /// REVIEW. a.boikov. 05/10/2024. Этот метод должен вычислить всего лишь координату падения.
            /// Она состоит из значения X и значения Y.
            /// Цикл не нужен. Обычная формула расчёта координаты падения

          