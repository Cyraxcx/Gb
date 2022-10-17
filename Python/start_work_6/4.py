# Задание 4 Задайте список из N элементов, заполненных числами из промежутка [-N, N].
# Найдите произведение элементов на позициях a и b.
# from random import randint
# n = int(input('Введите диапозон листа: '))
# a = int(input('Введите позицию а: '))
# b = int(input('Введите позицию b: '))

# def f(n,a,b):
#     lst = []
#     for i in range(n):
#             lst.append(randint(-10,15))
#     print(lst)
#     sum = lst[a] * lst[b]
#     print(f'произведение a и b =  {sum};')


# f(n,a,b)
from random import randint
n = int(input('Введите диапозон листа: '))
a, b = int(input('Введите позицию а: ')), int(input('Введите позицию b: '))

def f(n,a,b):
    lst = [(randint(-10,15)) for i in range(n)]        
    print(lst)
    sum = lst[a] * lst[b]
    print(f'произведение позиций a и b =  {sum};')

f(n,a,b)