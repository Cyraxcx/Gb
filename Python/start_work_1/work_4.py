#Напишите программу, которая по заданному номеру четверти, 
#показывает диапазон возможных координат точек в этой четверти (x и y).

number = int(input("Введите номер четверти: "))

if number < 0 or number > 4:
    print("Введите значение от 0 до 4") 
elif number == 0 and number == 0:
    print("Кордината в центре плоскости")
elif number == 1: 
    print('Возможные координаты x > 0 и у > 0')
elif number == 2:
    print('Возможные координаты x < 0 и y > 0')
elif number == 3:
    print('Возможные координаты x < 0 и y < 0:')
elif number == 4:
    print('Возможные координаты x > 0 и y < 0:')