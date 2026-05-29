using InfoEmpleados;

Empleado []preCarga = [
    new("Matias", "Nieto", new DateTime(1994,02,13), 's', new DateTime(2000, 08, 02), 5000, Cargos.investigador),
    new("Belen", "German", new DateTime(2004,07,03), 's', new DateTime(2015, 09, 01), 3000, Cargos.auxiliar),
    new("Emilia", "Gomez", new DateTime(1961,05,15), 'c', new DateTime(1994, 12, 24), 1000, Cargos.especialista)
];

double montoTotal = 0;
int prox = 0, cont = 0, indice = 0;

foreach (Empleado item in preCarga)
{
    Console.WriteLine(item.Edad);
    Console.WriteLine(item.Antiguo());
    Console.WriteLine(item.Jubi());
    Console.WriteLine($"Sueldo: {item.Salario()}");
    montoTotal += item.Salario();
    if (prox == 0)
    {
        prox = item.Jubi();
        indice = cont;
    }

    if (prox > item.Jubi())
    {
        prox = item.Jubi();
        indice = cont;
    }
    cont++;
}

Console.WriteLine($"Monto Total: {montoTotal}");

Console.WriteLine($"Proximo a jubilarse: {preCarga[indice].Nombre}");
Console.WriteLine(preCarga[indice].Apellido);
Console.WriteLine(preCarga[indice].FechaN);
Console.WriteLine(preCarga[indice].EstadoCivil);
Console.WriteLine(preCarga[indice].FechaI);
Console.WriteLine(preCarga[indice].SueldoBase);
Console.WriteLine(preCarga[indice].Salario());
Console.WriteLine(preCarga[indice].Cargo);
Console.WriteLine(preCarga[indice].Edad);
Console.WriteLine(preCarga[indice].Antiguo());
Console.WriteLine(preCarga[indice].Jubi());
