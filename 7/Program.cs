using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задача 1: Базовые операции");
            int[] numbers = new int[10];
            Random randoms = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randoms.Next(1, 101);
            }
            Console.WriteLine("Массив");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма всех элементов: {sum}");
            double srZnach = (double)sum / numbers.Length;
            Console.WriteLine($"Среднее арифметическое: {srZnach}");
            int Count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Count++;
                }
            }
            Console.WriteLine($"Количество четных чисел: {Count}");
            Console.WriteLine();


            //                 ЗАДАЧА 2
            Console.WriteLine("Задача 2: Поиск элементов");
            string[] languages = { "Русский", "Татарский", "Чувашский", "Мордовский", "Английский" };
            Console.WriteLine("Наш массив:");
            for (int i = 0; i < languages.Length; i++)
            {
                Console.Write(languages[i] + ", ");
            }
            Console.WriteLine();
            string longest = languages[0];
            for (int i = 1; i < languages.Length; i++)
            {
                if (languages[i].Length > longest.Length)
                {
                    longest = languages[i];
                }
            }
            Console.WriteLine("Самая длинная строка: " + longest);
            Console.WriteLine();

            Console.Write("Введите ключевое слово или часть слова, которого ищете: ");
            Console.WriteLine();
            string search = Console.ReadLine();
            bool notSearch = false;
            Console.Write("Найденные строки: ");
            for (int i = 0; i < languages.Length; i++)
            {
                if (languages[i].Contains(search))
                {
                    Console.WriteLine("Найденные строки:");
                    Console.WriteLine(languages[i]);
                    notSearch = true;
                }
            }
            if (!notSearch)
            {
                Console.Write("Таких строк нет");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите строку, индекс которой вам нужен!");
            string index = Console.ReadLine();
            int position = -1;
            for (int i = 0; i < languages.Length; i++)
            {
                if (languages[i] == index)
                {
                    position = i;
                    break;
                }
            }

            if (position != -1)
            {
                Console.WriteLine($"Найдено на позиции: {position}");
            }
            else
            {
                Console.WriteLine("Не найдено");
            }

            //                     ЗАДАЧА 3
            Console.WriteLine("Задача 3: Обработка числовых данных");
            double[] numberS = new double[15];
            Random randomS = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numberS[i] = randomS.NextDouble();
            }
            Console.WriteLine("Массив чисел:");
            for (int i = 0; i < numberS.Length; i++)
            {
                Console.Write($"{numberS[i]:F2}" + " ");
            }
            Console.WriteLine("\n");
            double min = numberS[0];
            double max = numberS[0];
            for (int i = 1; i < numberS.Length; i++)
            {
                if (numberS[i] < min)
                    min = numberS[i];

                if (numberS[i] > max)
                    max = numberS[i];
            }

            Console.WriteLine($"Минимальный элемент: {min:F2}");
            Console.WriteLine($"Максимальный элемент: {max:F2}");
            double difference = max - min;
            Console.WriteLine($"Среднее арифметическое: {difference:F2}");
            double summa = 0;
            for (int i = 0; i < numberS.Length; i++)
            {
                summa += numberS[i];
            }
            double BolSrCnach = summa / numberS.Length;
            Console.WriteLine($"Среднее арифметическое: {BolSrCnach:F2}");
            Console.WriteLine("Числа больше среднего: ");
            for (int i = 0; i < numberS.Length; i++)
            {
                if (numberS[i] > BolSrCnach)
                {
                    Console.Write($"{numberS[i]:F2}" + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            //               ЗАДАЧА 4
            int[] array = { 1, 0, 3, 0, 5, 0, 7, 0, 9 };
            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    count++;
            }
            Console.WriteLine();
            Console.WriteLine("Ненулевых элементов: " + count);
            int[] result = new int[count];
            int nullElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    result[nullElement] = array[i];
                    nullElement++;
                }
            }
            Console.Write("Массив без нулей: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            //5
            string[] employees =
        {
            "Родионов Никита Сергеевич-Менеджер",
            "Старков Владимир Олегович-Аналитик",
            "Шеенков Виктор Алексеевич-1C Разработичк",
            "Васильева Анна Владимировна-1C Разработчик",
            "Воронов Сергей Петрович-Аналитик",
            "Григорьев Иван Михайлович-Менеджер",
            "Жукова Елена Александровна-Разработчик"
        };
            Console.WriteLine("===Анализ сотрудников===");
            string targetPosition = "Менеджер";
            Console.WriteLine($"Сотрудники с должностью {targetPosition}:");
            var byPosition = employees
                .Where(e => e.Split('-')[1] == targetPosition);
            if (byPosition.Any())
            {
                foreach (var emp in byPosition)
                {
                    Console.WriteLine($"{emp.Split('-')[0]}");
                }
            }
            else
            {
                Console.WriteLine("Не найдено");
            }
            Console.WriteLine();
            char targetLetter = 'В';
            Console.WriteLine($"Сотрудники, чья фамилия начинается на {targetLetter}:");
            var FirstLetter = employees
                .Where(e => e.Split('-')[0].StartsWith(targetLetter.ToString()));
            if (FirstLetter.Any())
            {
                foreach (var emp in FirstLetter)
                {
                    Console.WriteLine($"{emp}");
                }

            }
            //6
            double[] temperatures = {
            -5, -3, 0, 2, 5, 8, 10,
            12, 14, 16, 18, 20, 22, 24,
            26, 28, 30, 29, 27, 25, 23,
            20, 18, 15, 12, 10, 8, 6, 4
        };
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write(temperatures[i] + " ");
            }
            Console.WriteLine();
            int daysCount = temperatures.Length;
            int weeksCount = 4;
            int daysPerWeek = 7;
            double sum1 = 0;
            for (int i = 0; i < daysCount; i++)
            {
                sum1 += temperatures[i];
            }
            double avgTemp = sum1 / daysCount;
            Console.WriteLine($"Средняя температура за месяц: {avgTemp:F2} °C");
            double minWeekSum = double.MaxValue;
            double maxWeekSum = double.MinValue;
            int coldestWeek = 1;
            int warmestWeek = 1;
            for (int week = 0; week < weeksCount; week++)
            {
                double weekSum = 0;
                for (int day = 0; day < daysPerWeek; day++)
                {
                    weekSum += temperatures[week * daysPerWeek + day];
                }
                double weekAvg = weekSum / daysPerWeek;

                if (weekAvg < minWeekSum)
                {
                    minWeekSum = weekAvg;
                    coldestWeek = week + 1;
                }
                if (weekAvg > maxWeekSum)
                {
                    maxWeekSum = weekAvg;
                    warmestWeek = week + 1;
                }
            }
            Console.WriteLine($"Самая холодная неделя: {coldestWeek}");
            Console.WriteLine($"Самая тёплая неделя: {warmestWeek}");
            Console.WriteLine("Дни с температурой выше средней:");
            for (int i = 0; i < daysCount; i++)
            {
                if (temperatures[i] > avgTemp)
                {
                    Console.Write($"{i + 1} ");
                }
            }
            Console.WriteLine();
            int frost = 0;
            int cold = 0;
            int warm = 0;
            int hot = 0;
            for (int i = 0; i < daysCount; i++)
            {
                double temp = temperatures[i];
                if (temp < -10)
                    frost++;
                else if (temp <= 0)
                    cold++;
                else if (temp <= 25)
                    warm++;
                else
                    hot++;
            }
            Console.WriteLine("Распределение по диапазонам:");
            Console.WriteLine($"Мороз больше -10: {frost} дней");
            Console.WriteLine($"Холодно примерно -10 до 0: {cold} дней");
            Console.WriteLine($"Тепло 0 до 25: {warm} дней");
            Console.WriteLine($"Жарко больше 25: {hot} дней");

            //7
            string[] products =
                {
            "Ноутбук-1200-Электроника",
            "Смартфон-800-Электроника",
            "Футболка-25-Одежда",
            "Джинсы-60-Одежда",
            "Кофеварка-150-БытоваяТехника",
            "Микроволновка-200-БытоваяТехника",
            "Наушники-100-Электроника",
            "Кроссовки-80-Одежда",
        };
            Console.WriteLine("КАТАЛОГ ТОВАРОВ");
            Console.WriteLine("Товары в диапазоне 50-200:");
            var priceRange = products.Where(p =>
            {
                var price = Convert.ToDouble(p.Split('-')[1]);
                return price >= 50 && price <= 200;
            });


            foreach (var product in priceRange)
            {
                var parts = product.Split('-');
                Console.WriteLine($"{parts[0]} - {parts[1]} - {parts[2]}");

            }
            Console.WriteLine();


            Console.WriteLine("Товары отсортированные по цене (возрастание):");
            var sortedByPriceAsc = products.OrderBy(p => Convert.ToDouble(p.Split('-')[1]));
            foreach (var product in sortedByPriceAsc)
            {
                var parts = product.Split('-');
                Console.WriteLine($"{parts[0]} - {parts[1]} - {parts[2]}");
            }
            Console.WriteLine();


            Console.WriteLine("Товары отсортированные по цене (убывание):");
            var sortedByPriceDesc = products.OrderByDescending(p => Convert.ToDouble(p.Split('-')[1]));
            foreach (var product in sortedByPriceDesc)
            {
                var parts = product.Split('-');
                Console.WriteLine($"{parts[0]} - {parts[1]} - {parts[2]}");
            }
            Console.WriteLine();

            Console.WriteLine("Количество товаров по категориям:");
            var categories = products.Select(p => p.Split('-')[2]).Distinct();
            foreach (var category in categories)
            {
                var count = products.Count(p => p.Split('-')[2] == category);
                Console.WriteLine($"{category}: {count} товаров");
                //Where() - фильтрация по условию

                //OrderBy() / OrderByDescending() - сортировка

                //First() - получение первого элемента

                //Average() - вычисление среднего значения

                //Count() - подсчет элементов

                //Select() + Distinct() - получение уникальных категорий
            }

            //8
            int[] results = { 45, 78, 92, 67, 95, 81, 68, 74, 89, 63, 79, 94, 83, 58, 96 };
            Console.WriteLine("=== СТАТИСТИКА РЕЗУЛЬТАТОВ ===");

            var sorted = results.OrderBy(r => r).ToArray();
            double median = sorted.Length % 2 == 0 ?
                (sorted[sorted.Length / 2 - 1] + sorted[sorted.Length / 2]) / 2.0 :
                sorted[sorted.Length / 2];
            Console.WriteLine($"Медиана: {median}");

            double avg = results.Average();
            double std = Math.Sqrt(results.Average(r => Math.Pow(r - avg, 2)));
            Console.WriteLine($"Стандартное отклонение: {std:F1}");
            // группировка по балам через вложенный цикл
            int topCount = (int)Math.Ceiling(results.Length * 0.1);
            int[] topResults = new int[topCount];
            for (int i = 0; i < results.Length - 1; i++)
            {
                for (int j = 0; j < results.Length - 1 - i; j++)
                {
                    if (results[j] < results[j + 1])
                    {
                        int temp = results[j];
                        results[j] = results[j + 1];
                        results[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < topCount; i++)
            {
                topResults[i] = results[i];
            }

            Console.WriteLine($"Топ {topCount} результатов: {string.Join(", ", topResults)}");


            Console.WriteLine("Группировка по баллам:");
            var groups = new[] { "0-59", "60-69", "70-79", "80-89", "90-100" };
            foreach (var group in groups)
            {
                int min = int.Parse(group.Split('-')[0]);
                int max = int.Parse(group.Split('-')[1]);
                int count = results.Count(r => r >= min && r <= max);
                Console.WriteLine($"{group}: {count} чел.");

            }

            //9
            string[] students =
               {
            "Дина-5,2,5",
            "Умар-3,4,3",
            "Элина-4,5,3",
            "Лина-5,3,2",
            "Ралина-4,4,5"
        };

            string[] subjects = { "Математика", "Физика", "Программирование" };
            Console.WriteLine("=== СИСТЕМА УЧЕТА СТУДЕНТОВ ===");
            Console.Write("Введите минимальный средний балл: ");
            double minAvg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Студенты со средним баллом > {minAvg}:");
            foreach (string student in students)
            {
                string[] parts = student.Split('-');
                string[] grades = parts[1].Split(',');
                double sum = 0;
                foreach (string grade in grades)
                {
                    sum += Convert.ToDouble(grade);
                }
                double avg = sum / grades.Length;

                if (avg > minAvg)
                {
                    Console.WriteLine($"{parts[0]} - {avg:F1}");
                }
            }
            double maxSubjectAvg = 0;
            string bestSubject = "";

            for (int i = 0; i < subjects.Length; i++)
            {
                double subjectSum = 0;
                foreach (string student in students)
                {
                    string[] grades = student.Split('-')[1].Split(',');
                    subjectSum += Convert.ToDouble(grades[i]);
                }
                double subjectAvg = subjectSum / students.Length;

                if (subjectAvg > maxSubjectAvg)
                {
                    maxSubjectAvg = subjectAvg;
                    bestSubject = subjects[i];
                }
            }
            Console.WriteLine($"Предмет с наивысшим средним баллом: {bestSubject} ({maxSubjectAvg:F2})");
            Console.WriteLine("Рейтинг студентов:");
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    string[] grades1 = students[i].Split('-')[1].Split(',');
                    string[] grades2 = students[j].Split('-')[1].Split(',');

                    double sum1 = 0, sum2 = 0;
                    foreach (string grade in grades1) sum1 += Convert.ToDouble(grade);
                    foreach (string grade in grades2) sum2 += Convert.ToDouble(grade);

                    double avg1 = sum1 / grades1.Length;
                    double avg2 = sum2 / grades2.Length;

                    if (avg1 < avg2)
                    {
                        string temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            foreach (string student in students)
            {
                string[] parts = student.Split('-');
                string[] grades = parts[1].Split(',');

                double sum = 0;
                foreach (string grade in grades) sum += Convert.ToDouble(grade);
                double avg = sum / grades.Length;

                Console.WriteLine($"{parts[0]} - {avg:F1}");
            }
            Console.WriteLine("Отличники средний балл >= 4.5:");
            foreach (string student in students)
            {
                string[] parts = student.Split('-');
                string[] grades = parts[1].Split(',');

                double sum = 0;
                foreach (string grade in grades) sum += Convert.ToDouble(grade);
                double avg = sum / grades.Length;

                if (avg >= 4.5) Console.WriteLine($"{parts[0]:F2}");
            }
            Console.WriteLine("Двоечники средний балл < 3.0:");
            foreach (string student in students)
            {
                string[] parts = student.Split('-');
                string[] grades = parts[1].Split(',');
                double sum = 0;
                foreach (string grade in grades) sum += Convert.ToDouble(grade);
                double avg = sum / grades.Length;

                if (avg < 3.0) Console.WriteLine($"{parts[0]:F2}");
            }
        }
    }
}
