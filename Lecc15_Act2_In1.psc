Algoritmo Lecc15_Act2_In1
	Definir num, i, contador, suma Como Entero
		
	suma = 0
		
	Para num = 1 Hasta 100 Hacer
			
		contador = 0
			
		Para i = 1 Hasta num Hacer
				
			Si num MOD i = 0 Entonces
				contador = contador + 1
			FinSi
				
		FinPara
			
		Si contador = 2 Entonces
			Escribir num
				
			suma = suma + num
		FinSi
			
	FinPara
		
	Escribir "La suma de los numeros primos es: ", suma
		
FinAlgoritmo
