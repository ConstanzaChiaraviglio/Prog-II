//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Problema1y2;

Pila pila = new Pila(5);
pila.añadir("Avion");
pila.añadir("Camion");
pila.añadir("Auto");
pila.añadir("Moto");
pila.añadir("Monopatín");

Console.WriteLine("El primer elemento de la pila es: " + pila.primero());
Console.WriteLine("La cantidad de elmentos son: "+ pila.Cantidad()); //Lo agregué para comprobar si la cantidad de elementos cambiaba
Console.WriteLine("la pila está vacia? " + pila.estaVacia());
Console.WriteLine("el elemento extraido es: " + pila.extraer());
Console.WriteLine("La cantidad de elmentos son: " + pila.Cantidad()); //

Cola cola = new Cola();
cola.añadir("Avion");
cola.añadir("Camion");
cola.añadir("Auto");
cola.añadir("Moto");
cola.añadir("Monopatín");

Console.WriteLine("\nEl primer elemento de la cola es: " + cola.primero());
Console.WriteLine("La cantidad de elmentos son: " + cola.Cantidad()); //Lo agregué para comprobar si la cantidad de elementos cambiaba
Console.WriteLine("la cola está vacia? " + cola.estaVacia());
Console.WriteLine("el elemento extraido es: " + cola.extraer());
Console.WriteLine("La cantidad de elmentos son: " + cola.Cantidad()); //