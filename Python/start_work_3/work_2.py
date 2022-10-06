'''Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Пример:
- [2, 3, 4, 5, 6] => [12, 15, 16];
- [2, 3, 5, 6] => [12, 15]'''

lst = list(map(int,input('Введите числа через пробел: ').split()))
result = []
sum = 0
j = len(lst) - 1

print(lst )

for i in range(len(lst)):

    sum += int(lst[i]) * lst[j]
    result.append(sum)
    sum = 0
    j -= 1

    if j == 1:
        break
        
print(result)