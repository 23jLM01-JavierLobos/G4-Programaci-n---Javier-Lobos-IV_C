Algoritmo Lecc11_Act3_In1
	Definir num1, num2 Como Entero
	
	Escribir Sin Saltar "Escriba el primer numero:"
	Leer num1
	Escribir Sin Saltar "Escriba el segundo numero:"
	Leer num2
	
	Si num1 < num2 Entonces
        menor = num1
        mayor = num2
    Sino
        menor = num2
        mayor = num1
    FinSi
    
    suma = 0
    i = menor
    
    Repetir
        suma = suma + i
        i = i + 1
    Hasta Que i > mayor
    
    Escribir "La suma de los numeros entre ", menor, " y ", mayor, " es: ", suma
	
FinAlgoritmo
