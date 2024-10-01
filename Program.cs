Auto BMW=new Auto("BMW", "M4", 2024,3);

BMW.Encender();
Console.WriteLine(BMW.MostrarEstado());
 
 class Vehiculo
{
    //propiedades o atributos:

    protected string? Marca;  //protected porque solo "yo"  y algunos podemos acceder.
    protected string? Modelo;
    protected int? Anio;
    protected int? Velocidad = 0;
    protected bool Contacto = false;
    //Metodos:

    public Vehiculo(string Marca, string Modelo, int Anio){  //Constructor
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Anio = Anio;
    }

    
    public string Encender()
    {   
        Contacto = true;
        return "El vehículo esta encendio";
    }

    public string apagar()
    {   
        Contacto = false;
        return "El vehículo se apagó correctamente.";
    }
    public void Acelerar()
    {
        Velocidad = Velocidad +1;
    }

    public void Desacelerar()
    {
        Velocidad = Velocidad -1;
    }

    public string Detener()
    {
        if (Velocidad <= 10){
            Velocidad = 0;
            return "El vehículo se detuvo";
        }
        else{
            return "El vehículo se rompio todo";
        }
    }

    virtual public string MostrarEstado()
    {
        return $"Marca:{Marca}\nModelo: {Modelo}\nAño: {Anio}\nVelocidad: {Velocidad}\n¿Está encendido?: {(Contacto? "SI":"NO")}"; 
    }
}
class Auto:Vehiculo{
    protected int? Puertas;
    public Auto(string Marca, string Modelo, int Anio, int Puertas):base(Marca, Modelo, Anio){
        this.Puertas = Puertas;
    }
    public override string MostrarEstado(){
        return $"{base.MostrarEstado()}\nPuertas: {Puertas}";
    }
}