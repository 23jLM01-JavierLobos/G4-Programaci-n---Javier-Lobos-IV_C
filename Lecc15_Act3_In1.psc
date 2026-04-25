Algoritmo Lecc15_Act3_In1
	Definir i, numero, suma, cont Como Entero
	
    suma = 0
    cont = 0
	
    Para i = 1 Hasta 20 Con Paso 1 Hacer
		
        numero = i * 7
        suma = suma + numero
		
        Si numero MOD 2 = 0 Entonces
            cont = cont + 1
        FinSi
		
    FinPara
	
    Escribir "La sumatoria de los primeros 20 multiplos de 7 es: ", suma
    Escribir "Cantidad de multiplos de 7 que son pares: ", cont
	
FinAlgoritmo
