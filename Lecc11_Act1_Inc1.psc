Algoritmo Lecc11_Act1_Inc1
	Definir cajonesocupados, capacidadtotal, opcion Como Entero
	capacidadtotal = 10
	cajonesocupados = 0
	
	Repetir
		Escribir "----------SISTEMA DE ACCESO----------"
		Escribir "Cajones Ocupados: ",cajonesocupados," / ",capacidadtotal
		Escribir "Cajones Disponibles: ",capacidadtotal - cajonesocupados
		Escribir "Presione [1] para ingresar un auto | [0] para salir del sistema"
		leer opcion
		
		Si opcion = 1 Entonces
			cajonesocupados = cajonesocupados + 1
			Escribir "Ticket Impreso. Bienvenido"
		SiNo
			Si opcion <> 0 Entonces
				Escribir "Opción no Válida"
			Fin Si
		Fin Si
		Escribir "------------------------------------"
	Hasta Que cajonesocupados>=capacidadtotal o opcion = 0
	
	Si cajonesocupados >= capacidadtotal Entonces
		Escribir "AVISO: Estacionamiento lleno"
		Escribir "No se permiten más ingresos"
	Fin Si
	
	Escribir "Cerrando el sistema de monitoreo..."
FinAlgoritmo
