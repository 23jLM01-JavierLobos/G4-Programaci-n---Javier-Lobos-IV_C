Algoritmo Lecc9_Act4_In1
	Definir num, tabla, resultado Como Entero
	
	Escribir Sin Saltar "Escriba un numero:"
	Leer num
	
	tabla = 1
	Mientras tabla <= 10 Hacer
		resultado = num * tabla
		Escribir num , " x " , tabla , " = " , resultado
		tabla = tabla + 1
	Fin Mientras
	
FinAlgoritmo
