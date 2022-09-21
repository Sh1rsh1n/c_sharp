# Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


digit = int(input('enter number: '))

if digit < 100:
	print('number less 3 digit')
else:
	result = 0
	val = 10
	while digit > 99:
		result = digit % val
		digit = digit // val
	print(result)
