Algoritmo Lecc11_Act2_Inc1
	Definir num, facto como entero
	Escribir sin saltar "Ingrese un numero:"
	Leer num
	
	facto=1
	
	Repetir
		facto=facto*num
		num=num-1
	Hasta Que num = 0
	
	Escribir "El factorial es: " , facto
FinAlgoritmo