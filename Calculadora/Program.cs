using EspacioCalculadora;

Calculadora calc = new Calculadora();
Console.WriteLine("Desea realizar una operacion: ");
string finalizar = Console.ReadLine();

while(finalizar == "1"){
    Console.WriteLine("Ingrese el Numero: ");
    string aux = Console.ReadLine();
    int num = int.Parse(aux);
    
    Console.WriteLine("Ingrese la operacion: ");
    string operacion = Console.ReadLine();

    switch(operacion){
        case "1":
        calc.Sumar(num);
        break;
        case "2":
        calc.Restar(num);
        break;
        case "3":
        calc.Multiplicar(num);
        break;
        case "4":
        calc.Dividir(num);
        break;
    }

    Console.WriteLine("Desea limpiar dato: ");
    string limp = Console.ReadLine();

    if(limp == "1"){
    calc.Limpiar();
    }

    Console.WriteLine($"Resultado: {calc.Resultado}");
    Console.WriteLine("Desea realizar una operacion: ");
    finalizar = Console.ReadLine();
}