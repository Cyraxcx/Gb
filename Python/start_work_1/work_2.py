#Напишите программу для. проверки истинности утверждения
#¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

def input_numbers(x=3):
    xyz = ["X", "Y", "Z"]
    a = []
    for i in range(x):
        a.append(input(f"Введите значение {xyz[i]}: "))
    return a


def check_predicate(x):
    return (not (x[0] or x[1] or x[2])) == (not x[0] and not x[1] and not x[2])


statement = input_numbers()

if check_predicate(statement) == True:
    print(f"Утверждение истинно")
else:
    print(f"Утверждение ложно")