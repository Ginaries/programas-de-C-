Vehiculo auto = new Vehiculo("BMW", "M4", 2024);
Console.WriteLine(auto.MostrarEstado());
 
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

    public string MostrarEstado()
    {
        return $"Marca:{Marca}\nModelo: {Modelo}\nAño: {Anio}\nVelocidad: {Velocidad}\n¿Está encendido?: {Contacto}"; 
    }
}