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

Console.WriteLine("Enter first operand");
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

    }
