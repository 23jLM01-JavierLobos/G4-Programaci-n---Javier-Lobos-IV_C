Algoritmo Lecc9_Act3_In2
	Definir num, i, contador Como Entero
	
	Escribir Sin saltar "Ingrese un numero:"
	Leer num
	
	i = 1
    contador = 0
    
    Mientras i <= num Hacer
        Si num % i = 0 Entonces
            contador = contador + 1
        FinSi
        i = i + 1
    FinMientras
    
    Si contador = 2 Entonces
        Escribir "El numero es primo"
    Sino
        Escribir "El numero NO es primo"
    FinSi
	
FinAlgoritmo
