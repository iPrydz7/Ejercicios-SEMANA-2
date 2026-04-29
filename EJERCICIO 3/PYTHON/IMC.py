# Programa para calcular el IMC

def obtener_datos():
    peso = float(input("Ingrese su peso (KG): "))
    altura = float(input("Ingrese su altura (m): "))
    return peso, altura


def validar_datos(peso, altura):

    if peso < 5 or peso > 400:
        print("Peso inválido")
        return False

    if altura < 0.6 or altura > 2.5:
        print("Altura inválida")
        return False

    return True


def calcular_imc(peso, altura):
    return peso / (altura ** 2)


def clasificar_imc(imc):

    if imc < 18.5:
        return "Bajo peso"

    elif imc < 25:
        return "Peso normal"

    elif imc < 30:
        return "Sobrepeso"

    else:
        return "Obesidad"


def main():

    peso, altura = obtener_datos()

    datos_validos = validar_datos(peso, altura)

    if datos_validos:

        imc = calcular_imc(peso, altura)

        clasificacion = clasificar_imc(imc)

        print(f"\nSu IMC es: {imc:.2f}")
        print(f"Clasificación: {clasificacion}")

    else:
        print("No se pudo calcular el IMC.")


main()