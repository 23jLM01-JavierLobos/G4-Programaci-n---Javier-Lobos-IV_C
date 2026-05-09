Algoritmo Lecc28_Act2_In1
	Definir tipo Como Caracter
    Definir TotBo, BoletosAdult, BoNinos Como Entero
    Definir TotD Como Real
    Definir seguir Como Caracter
	
    TotBo = 0
    BoletosAdult = 0
    BoNinos = 0
    TotD = 0
	
    seguir = "S"
	
    Mientras seguir = "S" Hacer
		
        Escribir "Ingrese tipo de boleto (1 = Adulto, 2 = Niño): "
        Leer tipo
		
        Si tipo = "1" Entonces
            BoletosAdult = BoletosAdult + 1
            TotD = TotD + 15
        SiNo
            Si tipo = "2" Entonces
                BoNinos = BoNinos + 1
                TotD = TotD + 10
            FinSi
        FinSi
		
        TotBo = TotBo + 1
		
        Escribir "¿Desea registrar otro boleto? (S/N): "
        Leer seguir
		
    FinMientras
	
    Escribir "----- RESUMEN -----"
    Escribir "Boletos totales: ", TotBo
    Escribir "Boletos adultos: ", BoletosAdult
    Escribir "Boletos niños: ", BoNinos
    Escribir "Dinero total: Q", TotD
	
FinAlgoritmo
