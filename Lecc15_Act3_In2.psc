Algoritmo Lecc15_Act3_In2
	Definir i, j Como Entero
    Definir Primo Como Logico
    Definir contadorP, sumaPar Como Entero
	
    contadorP = 0
    sumaPar = 0
	
    Para i = 300 Hasta 1 Con Paso -1 Hacer
		
        // Verificar si es par
        Si i MOD 2 = 0 Entonces
            sumaPar = sumaPar + i
        FinSi
		
        // Verificar si es primo
        Primo = Verdadero
		
        Si i < 2 Entonces
            Primo = Falso
        SiNo
            Para j = 2 Hasta i - 1 Hacer
                Si i MOD j = 0 Entonces
                    Primo = Falso
                FinSi
            FinPara
        FinSi
		
        Si Primo = Verdadero Entonces
            contadorP = contadorP + 1
        FinSi
		
    FinPara
	
    Escribir "Cantidad de numeros primos entre 300 y 1: ", contadorP
    Escribir "Suma de numeros pares entre 300 y 1: ", sumaPar
	
FinAlgoritmo
