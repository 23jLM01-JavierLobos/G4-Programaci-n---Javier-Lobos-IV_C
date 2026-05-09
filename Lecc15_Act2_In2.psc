Algoritmo Lecc15_Act2_In2
	
	Definir billete, contador100, suma100, i Como Entero
	
	contador100 = 0
	suma100 = 0
	
	Escribir "*************************"
	Escribir "Cajero de Supermercado"
	Escribir "*************************"
	
	Para i = 1 Hasta 1000 Hacer
		
		Escribir "Ingrese el valor del billete (20, 50 o 100): "
		Leer billete
		
		Escribir "Billete registrado, el billete es: ", billete
		
		Si billete = 100 Entonces
			
			contador100 = contador100 + 1
			suma100 = suma100 + billete
			
			Si suma100 >= 1000 Entonces
				Escribir "Se alcanzaron $1000 en billetes de 100."
			FinSi
			
		FinSi
		
	FinPara
	
	Escribir "Dinero total en billetes de 100: $", suma100
	
FinAlgoritmo