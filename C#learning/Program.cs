using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*this is a comment
 int для короткого long для довгого
float = 6-7 знаків після коми, double = 15-16 знаків після коми
bool як в пайтон = true or false
char = 'a' - один символ, string = "abc" - рядок
при double нічого не губить а при int губиться все після коми 
&& це як "and" в Python
|| це як "or" в Python
! це як "not" в Python
const - блокує змінення змінноїї далі в коді 
методи Math.Abs(робить з - +), Math.Sqrt(корінь квадрату), Math.Round(округлення), max, min, (піднесення до найбльшого або меншого)
.Length довжина рядка, .ToUpper() - робить всі букви великими, .ToLower() - робить всі букви маленькими
 .IndexOf("D"); виводить все що після заданої букви, .Substring(початок,кінець); виводить все від початку до кінця
 \'	'	Одинарні лапки
 \"	"    Подвійні лапки
 \\	\	Зворотна коса риска
break - вихід з циклу, continue - пропуск ітерації
.GetLength(кількість разів скільки має працювати цикл);
switch - приклад: оголошення змінної int day = 4; написати switch (day)потім всередені case 1:,2:,3, і тд 
то сase буде шукати метод з значенням 4 і виведе її але обовязково потрібнго оголосити вихід break
якщо не знайде то виведе те що в методі default: який працює як else в if
foreach перерахує все що є в списку через foreach (string змінна in список)
 
 */




namespace C_learning
{   
    class Number
    {
        public int num1;
        public int num2;
        public Number(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }
        public int Add()
        {
            return num1 + num2;
        }
        public int Subtract()
        {
            return num1 - num2;
        }
        public int Multiply()
        {
            return num1 * num2;
        }
        public double Divide()
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Налаштуємо колір для крутого вайбу
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== ХАКЕРСЬКИЙ ОБЧИСЛЮВАЛЬНИЙ МОДУЛЬ С# ===");

            // Запитуємо перше число
            Console.Write("Введіть перше число (int): ");
            int input1 = Convert.ToInt32(Console.ReadLine()); // Конвертуємо рядок в int

            // Запитуємо друге число
            Console.Write("Введіть друге число (int): ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть дію (+, -, *, /): ");
            string operation = Console.ReadLine();

            // Створюємо твій об'єкт класу Number і передаємо туди введені числа
            Number myCalc = new Number(input1, input2);

            if (operation == "+")
            {
                Console.WriteLine(myCalc.Add());
            }
            if (operation == "-")
            {
                Console.WriteLine(myCalc.Subtract());
            }
            if (operation == "*")
            {
                Console.WriteLine(myCalc.Multiply());
            }
            if (operation == "/")
            {
                Console.WriteLine(myCalc.Divide());
            }

        }
    }
}