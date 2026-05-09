Algoritmo Lecc10_Act3_In1
		
		Definir suma, i, j, contador Como Entero
		
		suma = 0
		
		Para i = 2 Hasta 22 Con Paso 1 Hacer
			
			contador = 0
			
			Para j <- 1 Hasta i Con Paso 1 Hacer
				
				Si i MOD j = 0 Entonces
					contador = contador + 1
				FinSi
				
			FinPara
			
			Si contador = 2 Entonces
				suma = suma + i
			FinSi
			
		FinPara
		
		Escribir "La suma de los numeros primos entre 1 y 22 es: ", suma
		
FinAlgoritmo
