//First task calculator
/*Задание 1
Напишите программу - консольный калькулятор.
Создайте две переменные с именами operand1 и operand2.
Задайте переменным некоторые произвольные значения.
Предложите пользователю ввести знак арифметической операции.
Примите значение, введенное пользователем, и поместите его в строковую переменную
sign.
Для организации выбора алгоритма вычислительного процесса, используйте
переключатель switch.
Выведите на экран результат выполнения арифметической операции.
В случае использования операции деления, организуйте проверку попытки деления на
ноль.
И если таковая имеется, то отмените выполнение арифметической операции и
уведомите об ошибке пользователя.*/

/*Console.WriteLine("Enter first operand");
double operand1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a math operation\n\'+\' \'-\' \'*\' \'/\' \'%\'");
char sign = char.Parse(Console.ReadLine());

Console.WriteLine("Enter second operand");
double operand2 = double.Parse(Console.ReadLine());


switch (sign) { 

        case '+':
            Console.WriteLine(operand1 + operand2);
            break;

        case '-':
            Console.WriteLine(operand1 - operand2);
            break;

        case '*':
            Console.WriteLine(operand1 * operand2);
            break;

        case '/':
            if (operand2 != 0) { Console.WriteLine(operand1 / operand2); }
            else { Console.WriteLine("Error division by zero!"); }
            break;

        case '%':
            if (operand2 != 0) { Console.WriteLine(operand1 % operand2); }
            else { Console.WriteLine("Error division by zero!"); }
            break;

        default:
            Console.WriteLine("Something wrong");
            break;

    }*/

//Second task numerical interval
/*Задание 2
Напишите программу определения, попадает ли указанное пользователем число от 0 до
100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100].
Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число, не входящее ни в один из имеющихся числовых
промежутков, то выводится соответствующее сообщение.Задание 2
Напишите программу определения, попадает ли указанное пользователем число от 0 до
100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100].
Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число, не входящее ни в один из имеющихся числовых
промежутков, то выводится соответствующее сообщение.*/
const int limitNumber1 = 0;
const int limitNumber2 = 100;

Console.WriteLine($"Enter integer number to check from {limitNumber1} to {limitNumber2}");

int number = int.Parse(Console.ReadLine());

if (number < limitNumber1) Console.WriteLine($"Going beyond the limit\n{number}<{limitNumber1}");

if (number > limitNumber2) Console.WriteLine($"Going beyond the limit\n{number}>{limitNumber2}");

if (number >= limitNumber1 && number <= 14) Console.WriteLine("The number is included in the interval from 0 to 14");

if (number >= 15 && number <= 35) Console.WriteLine("The number is included in the interval from 15 to 35");

if (number >= 36 && number <= 50) Console.WriteLine("The number is included in the interval from 36 to 50");

if (number >= 50 && number <= 100) Console.WriteLine("The number is included in the interval from 50 to 100");
