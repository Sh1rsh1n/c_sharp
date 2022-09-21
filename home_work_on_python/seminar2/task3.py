# Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


import random

digit = random.randint(1, 10)
print(digit)
dayOfWeek = 0

if digit < 8:
	dayOfWeek = digit
else:
	if digit % 7 == 0:
		dayOfWeek = 7
	else:
		dayOfWeek = digit % 7


if dayOfWeek <= 5 and dayOfWeek >= 1:
	print('is workday')
else:
	print('is weekend')
