# Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


firstDigit = int(input('enter a first number: '))
secondDigit = int(input('enter a second number: '))

if firstDigit < secondDigit:
	print('max number = ', secondDigit, 'min number = ', firstDigit)
else:
	print('max number = ', firstDigit, 'min number = ', secondDigit)


# ===============================
# Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


digitOne = int(input('enter a first number: '))
digitTwo = int(input('enter a second number: '))
digitThree = int(input('enter a third number: '))

if digitOne > digitTwo and digitOne > digitThree:
	print('max number = ', digitOne)
elif digitTwo > digitThree:
	print('max number = ', digitTwo)
else:
	print('max number = ', digitThree)


# Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


digit = int(input('enter a digit number: '))

if digit % 2 == 0:
	print('this even number')
else:
	print('this odd number')



# Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

num = int(input('enter a digit number: '))
count = 1

while count <= num:
	if count % 2 == 0:
		print(count)
	count = count + 1
