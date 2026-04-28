num1 = float(input("Ingrese el primer número: "))
num2 = float(input("Ingrese el segundo número: "))

print("1. Suma")
print("2. Resta")
print("3. Multiplicación")
print("4. División")

opcion = int(input("Seleccione una opción: "))

match opcion:
    case 1:
        print("Resultado:", num1 + num2)

    case 2:
        print("Resultado:", num1 - num2)

    case 3:
        print("Resultado:", num1 * num2)

    case 4:
        if num2 != 0:
            print("Resultado:", num1 / num2)
        else:
            print("No se puede dividir entre cero")

    case _:
        print("Opción inválida")