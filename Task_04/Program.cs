﻿//                                Почти счастливое число
// Петя любит счастливые числа. Всем известно, что счастливыми являются положительные целые числа, в десятичной записи 
// которых содержатся только счастливые цифры 4 и 7. Например, числа 47, 744, 4 являются счастливыми, а 5, 17, 467 — не являются.

// К сожалению, не все числа счастливые. Петя называет число почти счастливым, если количество счастливых цифр в 
// нем — счастливое число. Ему интересно, является ли число n почти счастливым.

// Входные данные
// В единственной строке задано целое число n (1 ≤ n ≤ 1018).

// Пожалуйста, не используйте спецификатор %lld для чтения или записи 64-битных чисел на С++. Рекомендуется использовать 
// потоки cin, cout или спецификатор %I64d.

// Выходные данные
// В единственной строке выведите «YES», если число n — почти счастливое, и «NO» в противном случае (без кавычек).

// Примеры
// входные данные
// 40047
// выходные данные
// NO
// входные данные
// 7747774
// выходные данные
// YES
// входные данные
// 1000000000000000000
// выходные данные
// NO
// Примечание
// В первом примере количество счастливых цифр числа равно 3 (первая и последние две цифры), поэтому ответ «NO».

// Во втором примере все цифры числа — счастливые, а их общее количество — 7, поэтому ответ «YES».

// В третьем примере в числе нет счастливых цифр, поэтому ответ «NO».


Console.WriteLine("Введите число для проверки: ");
int n = int.Parse(Console.ReadLine() ?? "0");
bool k = false;
for(int i=0; i < Digitsnumber(n); i++)
{
if((Digitindex(n,i+1) == 4 || Digitindex(n,i+1) == 7)
&&(Digitsnumber(n) == 4 || Digitsnumber(n) == 7))
k = true;
}
if(k == true)
{
Console.WriteLine("Да, введенное Вами число является счастливым.");
}
else
{
Console.WriteLine("Нет, введенное Вами число не является счастливым.");
}