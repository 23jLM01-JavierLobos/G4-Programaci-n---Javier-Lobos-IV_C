Algoritmo Lecc9_Act1_In1
	Definir pesoManzana, pesoTotal, ToMan como Entero
	
	//Inicializar la variable
	pesoTotal = 0
	ToMan = 0
	Mientras pesoTotal<1000 Hacer
		Escribir "Ingrese el peso de la manzana comprada"
		Leer pesoManzana
		
		Si pesoManzana >=180 Entonces
			pesoTotal=pesoTotal+pesoManzana
			Escribir "Llevo en total de peso: " , pesoTotal, " Gramos"
			ToMan=ToMan+1
		SiNo
			Escribir "Error. La manzana debe pesar al menos 180 gramos"
		Fin Si
	Fin Mientras
	
	Escribir "Ya se alcanzó un kilo de manzanas"
	Escribir "Compre: ", ToMan , " manzanas"
	
FinAlgoritmo
