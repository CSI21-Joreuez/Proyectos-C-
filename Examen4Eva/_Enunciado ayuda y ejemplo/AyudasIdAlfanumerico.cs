
//--- Campos de la Tienda:
string nombre; //<-- Nombre de la tienda


//--- Campos de PuestoTrabajo:
string nombre;	//<-- Nombre del Puesto
double sueldo;  //<-- Sueldo mensual de una empleada de ese puesto

//--- Los campos de la Trabajadora son: 
string id;           //Será una cadena compuesta por tres letras mayíusculas y un número. Identifica a cada empleada => no se puede repetir.     
int idPuestoTrabajo; // Un entero del 0 al 4. Se refiere al puesto de trabajo del empleado
int tipo;            // Un entero del 0 al 5. Servirá para incrementar el sueldo

//--- Campos de la Becaria: Además de los anteriores (excepto tipo) ...
int porcentaje; // % del sueldo que corresponde a su puesto 

//--- Esto te puede servir para construir los cinco primeros Puestos		
	("Encargada", 1800)
	("Cajera", 900)
	("Reponedora", 800)
	("Administrativa", 1000)
	("Atención Cliente", 1200)

//--- Esto te puede servir para construir las tres primeras trabajadoras y la becaria
	("ERT4", 1, 2)
	("ASD1", 0, 3)
	("FDS2", 2)
	("EDC1", 3, 33)


//--- Cabecera para presentar los Puestos de trabajo (opción 1 del menú)
Console.WriteLine("\n\n\n\n\t\t id   Puesto de Trabajo   Sueldo");
	Console.WriteLine("\t\t --  -------------------  ------");


//--- Para Presentar los costes  (opción 2 del menú)

// Cálculos
// Coste de la Trabajadora = <sueldo de su Puesto> * (1 + 0.2 * tipo)
// Coste de la Becaria     = 0.01 * < sueldo de su Puesto> * porcentaje

	// cabecera
	Console.WriteLine("\n\n\n\tTienda: {0} \n", nombre);
	Console.WriteLine("\t id   Puesto Trabajo\tSueldo\t Tipo\tCOSTE");
	Console.WriteLine("\t----  --------------\t------\t-----\t-----");

	// La línea de coste de la Trabajadora o la becaria
	Console.WriteLine("\t{0}  {1}{2}\t{3}\t{4}", id, ...

	//Pie
	Console.WriteLine("\t    \t         \t    \t     \t-----");
	Console.WriteLine("\t    \t         \t    \t       \t{0}", costeTotal);
