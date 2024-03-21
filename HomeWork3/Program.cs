//First task calculator

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

/* int limitNumber1 = 0;
 int limitNumber2 = 100;

Console.WriteLine($"Enter integer number to check from {limitNumber1} to {limitNumber2}");

int number = int.Parse(Console.ReadLine());

if (number < limitNumber1) Console.WriteLine($"Going beyond the limit\n{number}<{limitNumber1}");

if (number > limitNumber2) Console.WriteLine($"Going beyond the limit\n{number}>{limitNumber2}");

if (number >= limitNumber1 && number <= 14) Console.WriteLine("The number is included in the interval from 0 to 14");

if (number >= 15 && number <= 35) Console.WriteLine("The number is included in the interval from 15 to 35");

if (number >= 36 && number <= 50) Console.WriteLine("The number is included in the interval from 36 to 50");

if (number >= 50 && number <= 100) Console.WriteLine("The number is included in the interval from 50 to 100");*/


//Third task translater


/*теплый              warm
холодный            cold
ветренный           windy
штиль               calm
солнечно            sunny
пасмурно            Mainly cloudy
дождливо            it is rainy
сухо                dry
влажно              damp
жарко               hot*/

/*Console.WriteLine(@"Enter word:
                    теплый              warm
                    холодный            cold
                    ветренный           windy
                    штиль               calm
                    солнечно            sunny
                    пасмурно            Mainly cloudy
                    дождливо            it is rainy
                    сухо                dry
                    влажно              damp
                    жарко               hot");
string str = Console.ReadLine();

switch (str)
{
    case "теплый": Console.WriteLine("warm");
        break;
    case "холодный": Console.WriteLine("cold");
        break;
    case "ветренный": Console.WriteLine("windy");
        break;
    case " штиль": Console.WriteLine("calm");
        break;
    case "солнечно": Console.WriteLine("sunny");
        break;
    case "пасмурно": Console.WriteLine("Mainly cloudy");
        break;
    case "дождливо": Console.WriteLine("it is rainy");
        break;
    case "сухо": Console.WriteLine("dry");
        break;
    case "влажно": Console.WriteLine("damp");
        break;
    case "жарко": Console.WriteLine("hot");
        break;
    default: Console.WriteLine("Unknown word");
            break;
}
*/

//Fourth taks even number



//Firs way

Console.WriteLine("Enter number1: ");

int number1 = int.Parse(Console.ReadLine());

if (number1 % 2 == 0) Console.WriteLine("This is even number:");
else Console.WriteLine("this is not even number");

//Second way

Console.WriteLine("Enter number2: ");

int number2 = int.Parse(Console.ReadLine());

int remainder = number2 % 10;

switch (remainder)
{
    case 0: case 2: case 4: case 6: case 8: Console.WriteLine("This is even number:");
        break;
        default: Console.WriteLine("this is not even number");
        break ;

}




