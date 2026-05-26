namespace EspacioCalculadora;

public class Calculadora{
    private double dato;

    public Calculadora(){
        dato = 0;
    }

    public void Sumar(double x){
        dato += x;
    }
    public void Restar(double x){
        dato -= x;
    }
    public void Multiplicar(double x){
        dato *= x;
    }
    public void Dividir(double x){
        dato /= x;
    }
    public void Limpiar(){
        dato = 0;
    }
    public double Resultado{
        get => dato;
    }
}