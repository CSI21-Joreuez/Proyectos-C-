//--- Campos de la Pintura:
string nombreColor;
double precioM2; // <-- (precio por metro cuadrado de la pintura)

//--- Esto te puede servir para construir los cinco primeros Colores		
"Blanco", 4.5
"Verde", 3.8
"Salmón", 8.5
"Beige", 7.2
"Amarillo", 6.2


//--- Los campos de la Habitación son: 
string nombre;  // Nombre de la habitación
double mPared;  // metros de pared de la habitación
int numPuertas; // Número de puertas de 2 x 0.80 m2
int numVentanas;// Número de ventanas de 1x1 m2
int tipoPintura;// id del tipo de pintura en el catálogo [0..4]

//--- Campos de la Terraza: Además de las anteriores...
double mPretil;   // metros lineales de pretil

// Cálculos
//---------- Superficie a Pintar...
// de la Habitación: 
   SuperficiePintar = mPared * 2.5 - numPuertas * 1.6 - numVentanas
// de la Terraza:    
   SuperficiePintar = mPared * 2.5 - numPuertas * 1.6 - numVentanas + mPretil * 1.5

//---------- Precio Pintura de cualquier recinto
   PrecioPintura = SuperficiePintar * precioM2 


// Para la opción 4.- Presentar Precio te hará falta, en algún lugar completar alguna de estas dos líneas:
Console.WriteLine("   {0}{1}\t{2}\t{3}\t{4}\t{5}\t\t  {6}",

Console.WriteLine("   {0}{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t  {7}"