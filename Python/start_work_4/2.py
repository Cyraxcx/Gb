'''2. Задайте натуральное число N. Напишите программу, 
которая составит список простых множителей числа N.
*Пример*
- при N=236     ->   [2, 2, 59]'''



n = int(input("Введите натуральное число: "))
lst = []
i = 2

while i <= n:
    if n % i == 0:
        n /= i
        lst.append(i)
    else:
        i += 1
    
print(lst)