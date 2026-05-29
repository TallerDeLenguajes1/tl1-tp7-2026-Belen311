namespace InfoEmpleados;

public enum Cargos {auxiliar, administrativo, ingeniero, especialista, investigador};

public class Empleado{
    private string nombre;
    private string apellido;
    private DateTime fechaN;
    private char estadoCivil;
    private DateTime fechaI;
    private double sueldoBase;
    private Cargos cargo;

    public int Antiguo(){
        return DateTime.Now.Year - FechaI.Year;
    }

    public int Edad{
        get {return DateTime.Now.Year - FechaN.Year;}
    }

    public string Nombre { 
        get => nombre;
        }
    public string Apellido { 
        get => apellido;
        }
    public DateTime FechaN { 
        get => fechaN;
        }
    public char EstadoCivil { 
        get => estadoCivil;
        }
    public DateTime FechaI { 
        get => fechaI;
        }
    public double SueldoBase { 
        get => sueldoBase;
        }
    public Cargos Cargo { 
        get => cargo;
        }

    public int Jubi(){
        if(Edad == 65){
            return 0;
        }
        if (Edad < 65) {
            return 65 - Edad;
        }
        return 0;
    }

    public Empleado(string nom, string ape, DateTime fechaNa, char estadoC, DateTime fechaIn, double sueldoB, Cargos Cargo){
        nombre = nom;
        apellido = ape;
        fechaN = fechaNa;
        estadoCivil = estadoC;
        fechaI = fechaIn;
        sueldoBase = sueldoB;
        cargo = Cargo;
    }
    
    public double Salario()
    {
        double sueldo, adicional;

        if (Antiguo() <= 20)
        {
            adicional = SueldoBase * ((double)Antiguo()/100);
        } else {
            adicional = SueldoBase * 0.25;
        }

        if (Cargo == Cargos.ingeniero || Cargo == Cargos.especialista)
        {
            adicional += SueldoBase * 0.5;
        }

        if (EstadoCivil == 'c')
        {
            adicional += 150000;
        }

        sueldo = SueldoBase + adicional;
        return sueldo;
    }

    
    
}