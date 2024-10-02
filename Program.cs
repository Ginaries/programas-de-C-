using System.Security.Cryptography.X509Certificates;

class Program{   
    public static void Main(String[] args) {
        

        Console.WriteLine("Bienvenido a Simulation Car");

        while (true) {
            Console.WriteLine($"Elija una opcion para continuar\n1.Crear Auto");
            Console.Write($"\nLa opcion elegida es: ");
            ConsoleKey IngUser= Console.ReadKey().Key;Console.WriteLine(); 
            switch (IngUser) {
                case ConsoleKey.D1:
                    Console.WriteLine(">has elegido la opcion 1");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine(">Esta Saliendo del simulador");
                    break;
                default:
                    Console.WriteLine(">!!Opcion no valida!!<");
                    break;
            }
            if (IngUser == ConsoleKey.D2){
                break;
            }
        }
        
    } //ESTO DEJALO ACA, DESPUES LO SIGO. FIRMA ALEJANDRO <3
 
}
class Gestor{
    private string? Marca;
    private string? Modelo;
    private int? Precio;

    public Gestor(){
        this.Marca = Console.ReadLine();
        this.Modelo = Console.ReadLine();
        if (Marca=="BMW"||Marca=="Audi"){
            Random aleatorio = new Random();
            int price=aleatorio.Next(150000,350000);
            this.Precio=price;
        }
    }   

}

 class Vehiculo
{
    //propiedades o atributos:

    protected string? Marca;  //protected porque solo "yo"  y algunos podemos acceder.
    protected string? Modelo;
    protected int? Anio;
    protected int? Velocidad = 0;
    protected bool Contacto = false;
    protected bool Encendido=false;
    //Metodos:

    public Vehiculo(string Marca, string Modelo, int Anio){  //Constructor
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Anio = Anio;
    }

    
    virtual public string Encender()
    {   
        Contacto = true;
        Encendido=true;
        return "El vehículo esta encendio";
    }

    public string apagar()
    {   
        Contacto = false;
        return "El vehículo se apagó correctamente.";
    }
    public string Acelerar()
    {
        if (Encendido == true){
            Velocidad = Velocidad +7;
            return $"Velocidad Actual: {Velocidad}";
        }
        else{
            return "No puedes Acelerar si no enciendes el auto";
        }
    }

    public string Desacelerar()
    {
        if (Velocidad>0){
            Velocidad = Velocidad -5;
            if (Velocidad<=10){
                return $"vas a {Velocidad} y por lo tanto: {this.Detener()}";
            }
            else{
                return "El auto va muy rapido y no puede detenerse";
            }
        }
        else return "El auto no esta en movimiento";
    }

    public string Detener()
    {
        if (Velocidad <= 10){
            Velocidad = 0;
            return "El vehículo se detuvo";
        }
        else{
            return "Aun No puede detenerse";
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
    public string AbrirPuerta(int Puerta){
        switch (Puerta){
            case 1 :
                return "Puerta del Conductor Abierta.";
            case 2 :
                return "Puerta del Acompañante Abierta.";
            case 3 :
                return "Puerta del Cofre Abierta.";
            default:
                 return "Estas haciendo algo mal.";
       
    }
    }
    public override string Encender()
    {
        return "Todas las puertas se cerraron, "+base.Encender();
    }
}
