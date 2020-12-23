using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1.
            //Task1();

            // Задача 2.
            //Task2();

            // Задача 3.
            //Task3();

            // Задача 4.
            // Task4();

            // Задача 5.
            //Task5();

            // Задача 6.
            // Task6();

            // Задача 7.
            Task7();
        }

        // Задача 1.
        // Написать метод, возвращающий минимальное из трёх чисел.
        static void Task1()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 1\n";
            description += "Написать метод, возвращающий минимальное из трёх чисел.\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");


            int[] numbers = { 5, 7, 90, 345, 122, 4};
            int minVal = getIntMin(numbers);

            // Вывод данных
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("\nЦифры: "+ string.Join(", ", numbers));
            Console.WriteLine("\nМинимальное значение: " + minVal);
            Console.ReadKey();
        }

        // Метод для задачи 1
        static int getIntMin(int[] numbers)
        {
            return (numbers.Length > 0) ? numbers.Min() : 0;
        }


        // Задача 2.
        // Написать метод подсчета количества цифр числа.
        static void Task2()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 2\n";
            description += "Написать метод подсчета количества цифр числа.\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            long number = 4937509353982503;

            // Вывод данных
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("\nЧисло: " + number);
            Console.WriteLine("\nКоличество цифр: " + number.ToString().Length);
            Console.ReadKey();
        }


        // Задача 3.
        // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Task3()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 3\n";
            description += "С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Накапливаем числа через консоль
            ArrayList numbers = new ArrayList();
            while (true)
            {
                Console.WriteLine("Введите число:");
                string data = Console.ReadLine();
                int number;
                if (data != "0") Int32.TryParse(data, out number); else break;
                if (number > 0) numbers.Add(number);
            }

            // Считаем сумму 
            int sum = 0;
            for(int i=0; i<numbers.Count; i++) if ((int)numbers[i]>0 && (int)numbers[i] % 2 != 0) sum += (int)numbers[i];
            

            // Вывод данных
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("\nЦифры: " + string.Join(", ", numbers.ToArray()));
            Console.WriteLine("\nСумму всех нечетных положительных чисел: " + sum);
            Console.ReadKey();
        }


        // Задача 4.
        // Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        static void Task4()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 4\n";
            description += "Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.\nНа выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).\nИспользуя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.\nС помощью цикла do while ограничить ввод пароля тремя попытками.\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Запрос логина и пароля
            int errors = 1;
            do {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();
                // Проверяем
                if(Auth(login, password))
                {
                    Console.WriteLine("Авторизация прошла успешно!");
                    break;
                } else
                {
                    int ch = 3 - errors;
                    if (ch > 0)
                    {
                        Console.WriteLine("Не верный логин или пароль. Попробуйте ещё раз. Осталось попыток: " + ch.ToString());
                    } else
                    {
                        Console.WriteLine("Авторизация НЕ прошла!");
                    }
                    errors++;
                }
            } while (errors<4);
            Console.ReadKey();
        }

        // Метод для задачи 4
        static bool Auth(string login, string password)
        {
            return (login == "root" && password == "GeekBrains") ? true : false;
        }

        // Задание 5.
        /*
        а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        */
        static void Task5()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 5\n";
            description += "а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.\n";
            description += "б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.\n";
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
            double heightM = (double)height / 100;

            // Считаем ИМТ
            double imt = weight / Math.Pow(heightM, 2);
            imt = Math.Round(imt, 2);

            // Считаем вес максимального и минимального ИМТ для текущего роста
            double weightMax, weightMin;
            weightMax = Math.Pow(heightM, 2) * 24.99;
            weightMin = Math.Pow(heightM, 2) * 18.5;

            // Вывод данных
            Console.WriteLine("Результат:\n");
            Console.WriteLine("Рост: " + height + " см.\nВес: " + weight + "кг.\nИМТ: " + imt + " кг/м2\n");

            // 18,50 — 24,99	Норма ИМТ
            double change = 0;
            if (imt>=18.5 && imt<=24.99)
            {
                Console.WriteLine("Индекс массы тела соответствует норме.");
            } else if(imt< 18.5)
            {
                change = Math.Round(weightMin - weight, 2);
                Console.WriteLine("Индекс массы тела Не соответствует норме. Необходимо поправится на "+ change + " кг.");
            } else if(imt > 24.99)
            {
                change = Math.Round(weight - weightMax, 2);
                Console.WriteLine("Индекс массы тела Не соответствует норме. Необходимо похудеть на " + change + " кг.");
            }

            // Задержка
            Console.ReadKey();
        }


        // Задача 6.
        // *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

        static void Task6()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 6\n";
            description += "*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.\nРеализовать подсчёт времени выполнения программы, используя структуру DateTime.\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            int cnt = 0;
            long sum;
            int unixTimestampStart = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            for (long i=1; i<1000000000; i++)
            {
                sum = getSum(i);
                if (i % sum == 0) cnt++;
            }
            int unixTimestampStop = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;


            // Вывод данных
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("\nКоличество \"хороших\" чисел: " + cnt.ToString());
            Console.WriteLine("\nВремя выполнения: " + (unixTimestampStop-unixTimestampStart).ToString()+" сек.");
            Console.ReadKey();
        }

        // Метод к задаче 6
        // Возвращает сумму своих цифр числа
        static long getSum(long n)
        {
            long k;
            long sum = 0;
            while (n != 0)
            {
                k = n % 10;
                sum += k;
                n /= 10;
            }
            return sum;
        }


        // Задача 7.
        // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        static void Task7()
        {
            Console.Write("\n------------------------------------------------------\n");
            string description = "Задание 7\n";
            description += "a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).\n";
            description += "б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.\n";
            Console.Write(description);
            Console.Write("------------------------------------------------------\n");

            // Сбор данных
            int a, b;
            Console.WriteLine("Число a:");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Число b:");
            Int32.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("\nРезультат:");
            if (a>0 && b>0 && a<b)
            {
                showNumber(a, b);
            } else
            {
                Console.WriteLine("Ошибка в указании цифр:\n - только целые (int) числа;\n - число (а) должно быть меньше числа (b);");
            }

            Console.ReadKey();
        }

        // Метод для задачи 7
        static void showNumber(int a, int b, int sum=0)
        {
            if(a<=b)
            {
                Console.WriteLine(a);
                sum += a;
                a++;
                showNumber(a,b,sum);
            } else
            {
                Console.WriteLine("Сумма чисел: "+ sum);
            }
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
            return (data.Length >= 3) ? data : "";
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
