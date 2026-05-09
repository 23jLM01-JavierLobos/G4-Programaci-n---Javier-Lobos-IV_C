Algoritmo Lecc9_Act2_In1
	Definir Nivel, Monedas, TotalMonedas Como Entero
	
	Nivel=0
	Monedas=0
	TotalMonedas=0
	
	Mientras TotalMonedas < 350 Hacer
		Escribir "Ingrese la cantidad de monedas que tiene:"
		Leer Monedas
		TotalMonedas=TotalMonedas+Monedas
		Escribir "Total de Monedas: ", TotalMonedas
		
		Si TotalMonedas >= 350 Entonces
			Escribir "¡¡¡HA LLEGADO AL NIVEL 5!!!"
		SiNo
			Escribir "Necesita más monedas para subir de nivel"
		Fin Si
	Fin Mientras
FinAlgoritmo
