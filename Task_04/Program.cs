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


int[] array = {7,7,4,7,7,7,4};
int n = array.Length;
int count = 0;
int index = 0;
int happi = 0;

while (index < n)
{
    if (array[index] % 7 == 0)
    {
        count++;
        index++;
    }
    if (array[index] % 4 == 0)
    {
        count++;
        index++;
    }
}

if (count % 7 == 0)
{
    happi++;
}
if (count % 4 == 0)
{
    happi++;
}

if (happi > 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}