# Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

import random
digit = random.randint(100,1000)
print(digit)

val = 10
result = digit // val % val

print(result)
