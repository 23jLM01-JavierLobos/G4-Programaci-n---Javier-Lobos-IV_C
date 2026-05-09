Algoritmo Lecc11_Act3_In2
	Definir numero, suma Como Entero
	suma = 0
		
	Repetir
			
		Escribir "Ingrese un numero (9 para terminar): "
		Leer numero
			
		Si numero <> 9 Entonces
			suma = suma + numero
		FinSi
			
	Hasta Que numero = 9
		
	Escribir "La suma total es: ", suma
		
FinAlgoritmo
	
