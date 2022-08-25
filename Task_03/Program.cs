//                                        Красивый год
// Кажется, еще совсем недавно наступил новый 2013 год. А знали ли Вы забавный факт о том, что 2013 год является первым 
// годом после далекого 1987 года, в котором все цифры различны?

// Теперь же Вам предлагается решить следующую задачу: задан номер года, найдите наименьший номер года, который строго 
// больше заданного и в котором все цифры различны.

// Входные данные
// В единственной строке задано целое число y (1000 ≤ y ≤ 9000) — номер года.

// Выходные данные
// Выведите единственное целое число — минимальный номер года, который строго больше y, в котором все цифры различны. 
// Гарантируется, что ответ существует.

// Примеры
// входные данные
// 1987
// выходные данные
// 2013
// входные данные
// 2013
// выходные данные
// 2014

int y = 1987;
int y2 = 1988;
int firstNumber = y2 / 1000;
Console.WriteLine(firstNumber);
int secondNumber = y2 / 100 % 10;
Console.WriteLine(secondNumber);
int thirdNumber = y2 % 100 / 10;
Console.WriteLine(thirdNumber);
int fourthNumber = y2 % 10;
Console.WriteLine(fourthNumber);
while (y2 < 9000)
{
    if (firstNumber != secondNumber 
    && secondNumber != thirdNumber && thirdNumber != firstNumber 
    && thirdNumber != fourthNumber && fourthNumber != secondNumber && fourthNumber != firstNumber)
    {
        Console.WriteLine("YES");
        break;
    }
    else
    {
        y2 = y2 + 1;
    }
}
Console.WriteLine(y2);