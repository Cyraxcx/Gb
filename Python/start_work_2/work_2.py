# Задание 2 Напишите программу, которая принимает на вход
# число N и выдает набор произведений чисел от 1 до N.
# Пример:
# пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

def func(N):

    sum = 1
    lst = []
    for i in range(1,N+1):
        sum *= int(i)
        lst.append(sum)
    print(lst)

N = int(input('Введите число: ')) 
func(N)