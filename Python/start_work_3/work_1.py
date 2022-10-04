a = int(input('Введи число: '))
 
d = ''
 
while a > 0:
    d = str(a % 2) + d
    a = a // 2
 
print(d)