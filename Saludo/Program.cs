// Creamos la variable para almacenar el nombre
String miNombre = "";
// Solicitamos por consola que el usuario ingrese el nombre
Console.WriteLine("Por favor, escriba su nombre");
// asignamos a la variable miNombre el valor que ingreso el usuario
miNombre = Console.ReadLine();
// imprimimos por consola el saludo
Console.WriteLine("Hola {0}", miNombre);
// Para que no se cierre la aplicación de golpe
Console.ReadKey();