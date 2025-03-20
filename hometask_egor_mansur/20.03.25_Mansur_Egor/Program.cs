using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK_MANSUR_EGOR
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите программу для запуска (1-14):");
                Console.WriteLine("1. Класс Person");
                Console.WriteLine("2. Класс Car (Инкапсуляция)");
                Console.WriteLine("3. Использование enum (Цвет)");
                Console.WriteLine("4. Статическое поле (Counter)");
                Console.WriteLine("5. Константы и readonly (Circle)");
                Console.WriteLine("6. Классы с конструкторами (Book)");
                Console.WriteLine("7. Методы (Calculator)");
                Console.WriteLine("8. Возврат кортежа (Statistics)");
                Console.WriteLine("9. Перегрузка методов (Printer)");
                Console.WriteLine("10. Необязательные параметры (FormatDate)");
                Console.WriteLine("11. Свойства с проверками (Employee)");
                Console.WriteLine("12. Индексаторы (Team)");
                Console.WriteLine("13. Partial-классы (Product)");
                Console.WriteLine("14. Управление заказами (Order, Customer)");
                Console.WriteLine("0. Выход");

                Console.Write("Введите номер программы: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                    {
                        Console.WriteLine("Выход из программы. До свидания!");
                        break;
                    }

                    switch (choice)
                    {
                        case 1: RunPersonExample(); break;
                        case 2: RunCarExample(); break;
                        case 3: RunCarWithEnumExample(); break;
                        case 4: RunCounterExample(); break;
                        case 5: RunCircleExample(); break;
                        case 6: RunBookExample(); break;
                        case 7: RunCalculatorExample(); break;
                        case 8: RunStatisticsExample(); break;
                        case 9: RunPrinterExample(); break;
                        case 10: RunFormatDateExample(); break;
                        case 11: RunEmployeeExample(); break;
                        case 12: RunTeamExample(); break;
                        case 13: RunProductExample(); break;
                        case 14: RunOrderSystemExample(); break;
                        default: Console.WriteLine("Некорректный выбор. Попробуйте снова."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Введите корректное число.");
                }

                Console.WriteLine(); // Пустая строка для разделения
            }
        }

        // Методы для запуска каждой программы
        static void RunPersonExample()
        {
            var person = new Person("Alice", 25);
            Console.WriteLine(person.Greet());
        }

        static void RunCarExample()
        {
            var car = new Car { Model = "Toyota", Year = 2020 };
            Console.WriteLine($"Модель: {car.Model}, Год выпуска: {car.Year}");
        }

        static void RunCarWithEnumExample()
        {
            var car = new CarWithEnum("BMW", Color.Red);
            Console.WriteLine($"Модель: {car.Model}, Цвет: {car.CarColor}");
        }

        static void RunCounterExample()
        {
            new Counter();
            new Counter();
            Console.WriteLine($"Создано экземпляров: {Counter.GetInstanceCount()}");
        }

        static void RunCircleExample()
        {
            var circle = new Circle();
            double area = circle.CalculateArea(Circle.DEFAULT_RADIUS);
            Console.WriteLine($"Площадь круга с радиусом {Circle.DEFAULT_RADIUS}: {area}");
        }

        static void RunBookExample()
        {
            var book = new Book("1984", "George Orwell", 1949);
            Console.WriteLine($"Книга: {book.Title} ({book.Year}), Автор: {book.Author}");
        }

        static void RunCalculatorExample()
        {
            var calculator = new Calculator();
            Console.WriteLine($"2 + 3 = {calculator.Sum(2, 3)}");
        }

        static void RunStatisticsExample()
        {
            var statistics = new Statistics();
            var result = statistics.Analyze(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"Минимум: {result.Min}, Максимум: {result.Max}, Среднее: {result.Average}");
        }

        static void RunPrinterExample()
        {
            var printer = new Printer();
            printer.Print("Привет, мир!");
            printer.Print(42);
            printer.Print(3.14);
        }

        static void RunFormatDateExample()
        {
            var formatter = new DateFormatter();
            Console.WriteLine(formatter.FormatDate(year: 2022, month: 12, day: 25));
        }

        static void RunEmployeeExample()
        {
            var employee = new Employee { Name = "John", Salary = 1000 };
            Console.WriteLine($"Сотрудник: {employee.Name}, Зарплата: {employee.Salary}");
        }

        static void RunTeamExample()
        {
            var team = new Team();
            team.AddEmployee(new Employee { Name = "Alice", Salary = 1500 });
            Console.WriteLine($"Сотрудник №1: {team[0].Name}, Зарплата: {team[0].Salary}");
        }

        static void RunProductExample()
        {
            var product = new Product { Name = "Laptop", Price = 1000 };
            Console.WriteLine($"Цена со скидкой: {product.GetDiscountedPrice(10)}");
        }

        static void RunOrderSystemExample()
        {
            var order = new Order();
            order.Items.Add(new OrderItem { Name = "Book 1", Price = 15.99m });
            order.Items.Add(new OrderItem { Name = "Book 2", Price = 20.00m });
            Console.WriteLine($"Общая сумма заказа: {order.CalculateTotal()}");
        }
    }
}
