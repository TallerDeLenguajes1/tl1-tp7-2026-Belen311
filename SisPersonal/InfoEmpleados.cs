namespace InfoEmpleados;

public enum {"auxiliar", "administrativo", "ingeniero", "especialista", "investigador"}

public class Empleado{
    private string nombre;
    private string apellido;
    private datetime fechaN;
    private char estadoCivil;
    private datetime fechaI;
    private double sueldoBase;
    private cargos cargo;

    public int antiguo(){
        return datetime.Now.Year - fechaI.Year;
    }

    public int Edad{
        get {return datetime.Now.Year - fechaN} 
    }

    public int jubi(){
        if(Edad == 65){
            return 0;
        } else if (Edad < 65) {
            return 65 - Edad;
        }
    }

    
}