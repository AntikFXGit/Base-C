using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Селиверстов Максим.\n\n");

            // Задание 1.
            Task1();

            // Задание 2.
            Task2();

            // Задание 3.
            Task3();

            // Задание 4.
            Task4();

            // Задание 5.
            Task5("в");
        }

        // Задание 1.
        /*
        Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        а) используя  склеивание;
        б) используя форматированный вывод;
        в) используя вывод со знаком $.
        */
        static void Task1()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 1\n";
            description += "Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:\n";
            description += "а) используя  склеивание;\n";
            description += "б) используя форматированный вывод;\n";
            description += "в) используя вывод со знаком $\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Решение
            // Сбор данных:
            ConsoleData inputData = new ConsoleData();
            
            // Имя
            string name = "";
            while (1==1) { name = inputData.getString("Введите ваше имя:"); if (name.Length > 0) break; else Console.WriteLine("Ошибка! Минимум 3 символа. Попробуйте ещё раз...\n"); }

            // Фамилия
            string surname = "";
            while (1 == 1) { surname = inputData.getString("Введите вашу фамилию:"); if (surname.Length > 0) break; else Console.WriteLine("Ошибка! Минимум 3 символа. Попробуйте ещё раз...\n"); }

            // Возраст
            int age = 0;
            while (1 == 1) { age = inputData.getInt("Укажите ваш возраст (полных лет):"); if (age > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }

            // Вес
            double weight = 0;
            while (1 == 1) { weight = inputData.getDouble("Укажите ваш вес (кг):"); if (weight > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }

            // Рост
            int height = 0;
            while (1 == 1) { height = inputData.getInt("Укажите ваш рост (см):"); if (height > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }

            // Вывод данных
            Console.WriteLine("\nРезультат:");
            // а) используя  склеивание
            Console.Write("а) используя  склеивание:\n");
            Console.WriteLine(surname+" "+ name+"\nВозраст: "+ age+ "\nРост: " + height + " см.\nВес: " + weight + "кг.\n");
            // б) используя форматированный вывод
            Console.Write("б) используя форматированный вывод:\n");
            Console.WriteLine("{0:G1} {1:G1}\nВозраст: {2:D2}\nРост: {3:D3} см.\nВес: {4:F1} кг.\n", surname, name, age, height, weight);
            // в) используя вывод со знаком $
            Console.Write("в) используя вывод со знаком $:\n");
            Console.WriteLine($"{surname} {name}\nВозраст: {age}\nРост: {height} см.\nВес: {weight} кг.\n" );

            // Задержка
            Console.ReadKey();

        }


        // Задание 2.
        /*
        Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
        */
        static void Task2()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 2\n";
            description += "Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);\n";
            description += "где m — масса тела в килограммах\n";
            description += "h — рост в метрах\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Решение
            // Сбор данных:
            ConsoleData inputData = new ConsoleData();

            // Вес
            double weight = 0;
            while (1 == 1) { weight = inputData.getDouble("Укажите ваш вес (кг):"); if (weight > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }

            // Рост
            int height = 0;
            while (1 == 1) { height = inputData.getInt("Укажите ваш рост (см):"); if (height > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }
            // Переводим в метры
            double heightM = (double) height / 100;

            // Считаем ИМТ
            double imt = weight / Math.Pow(heightM, 2);
            imt = Math.Round(imt, 2);

            // Вывод данных
            Console.WriteLine("Результат:\n");
            Console.WriteLine("Рост: " + height + " см.\nВес: " + weight + "кг.\nИМТ: "+ imt +" кг/м2");

            // Задержка
            Console.ReadKey();
        }


        // Задание 3.
        /*
        а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        */

        static void Task3()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 3\n";
            description += "а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);\n";
            description += "б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Решение
            // Сбор данных:
            ConsoleData inputData = new ConsoleData();

            // X1
            int x1 = 0;
            while (1 == 1) { x1 = inputData.getInt("Координата Х1:"); if (x1 > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }
            // Y1
            int y1 = 0;
            while (1 == 1) { y1 = inputData.getInt("Координата Y1:"); if (y1 > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }
            // X2
            int x2 = 0;
            while (1 == 1) { x2 = inputData.getInt("Координата Х2:"); if (x2 > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }
            // Y2
            int y2 = 0;
            while (1 == 1) { y2 = inputData.getInt("Координата Y2:"); if (y2 > 0) break; else Console.WriteLine("Ошибка! Попробуйте ещё раз...\n"); }

            // Считаем расстояние между точкам (сразу методом)
            double r = getDistancePoints(x1,y1,x2,y2);

            // Вывод данных
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("Расстояние между точкам: {0:F2}", r);

            // Задержка
            Console.ReadKey();
        }

        // Метод для Задачи 3
        static double getDistancePoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


        // Задание 4.
        /*
            Написать программу обмена значениями двух переменных:
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.
        */
        static void Task4()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 4\n";
            description += "Написать программу обмена значениями двух переменных:\n";
            description += "а) с использованием третьей переменной;\n";
            description += "б) *без использования третьей переменной.\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Решение
            int a = 1, b = 2;

            // a.
            int c = a;
            a = b;
            b = c;

            // б.
            (a, b) = (b, a); // обмен

            // Вывод данных
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("Решение представлено в коде программы.\n");
            // Задержка
            Console.ReadKey();
        }


        // Задание 5
        /*  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) *Сделать задание, только вывод организовать в центре экрана.
            в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
         */
        static void Task5(string type="а")
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 5\n";
            description += "а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.\n";
            description += "б) *Сделать задание, только вывод организовать в центре экрана.\n";
            description += "в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Решение
            // Сбор данных:
            ConsoleData inputData = new ConsoleData();

            // Имя
            string name = "";
            while (1 == 1) { name = inputData.getString("Введите ваше имя:"); if (name.Length > 0) break; else Console.WriteLine("Ошибка! Минимум 3 символа. Попробуйте ещё раз...\n"); }

            // Фамилия
            string surname = "";
            while (1 == 1) { surname = inputData.getString("Введите вашу фамилию:"); if (surname.Length > 0) break; else Console.WriteLine("Ошибка! Минимум 3 символа. Попробуйте ещё раз...\n"); }

            // Город
            string city = "";
            while (1 == 1) { city = inputData.getString("Введите ваш город:"); if (city.Length > 0) break; else Console.WriteLine("Ошибка! Минимум 3 символа. Попробуйте ещё раз...\n"); }

            // Вывод данных
            Console.Clear();
            Console.WriteLine("\nРезультат:");

            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            if (type == "а")
            {
                Console.WriteLine(surname + " " + name + ", "+ city + "\n");
            }
            
            // б) *Сделать задание, только вывод организовать в центре экрана.
            // в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
            if (type == "б" || type == "в")
            {
                string text = surname + " " + name + ", " + city;
                double centerX, centerY;
                int x, y;
                centerX = (Console.WindowWidth - text.Length) / 2;
                centerX = Math.Round(centerX);
                centerY = Console.WindowHeight / 2;
                centerY = Math.Round(centerY);
                x = (int)centerX;
                y = (int)centerY;

                if (type == "б") {
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.WriteLine(text);
                } else
                {
                    PrintConsole(text, x, y);
                }
            }
            // Задержка
            Console.ReadKey();

        }


        // Метод для Задачи 5
        static void PrintConsole(string text, int x, int y)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.WriteLine(text);
        }

    }



    class ConsoleData
    {
        public int getInt(string message)
        {
            Console.WriteLine(message);
            int data;
            Int32.TryParse(Console.ReadLine(), out data);
            return (data > 0) ? data : 0;
        }


        public string getString(string message)
        {
            Console.WriteLine(message);
            string data = Console.ReadLine();
            return (data.Length>=3) ? data : "";
        }

        public double getDouble(string message)
        {
            Console.WriteLine(message);
            double data;
            Double.TryParse(Console.ReadLine(), out data);
            return (data > 0) ? data : 0;
        }

    }


}
