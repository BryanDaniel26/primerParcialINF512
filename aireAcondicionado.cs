
using System;

class AireAcondicionado
{
    private string Marca {set; get;} //Modelos aceptados: SAMSUNG HAIER NEDOCA
    private int Temperatura {set; get;}
    private int VelocidadFan {set; get;}
    private string Status {set; get;}

    //Constructor
    public AireAcondicionado(string Marca, int Temperatura, int VelocidadFan, string Status)
    {
        this.Marca = Marca;
        this.Temperatura = Temperatura;
        this.VelocidadFan = VelocidadFan;
        this.Status = Status;

    }

    //Constructor de aire acondicionado apagado
    public AireAcondicionado()
    {
        this.Marca = "SAMSUNG";
        this.Temperatura = 14;
        this.VelocidadFan = 0;
        this.Status = "Apagado";
    }

    //Funcionalidades del aire acondicionado

    public void setEncender(string encendido)
    {
        this.Status = encendido;
    }
    public string getEncender()
    {
        return Status;
    }

    public void setApagar(string apagado)
    {
        this.Status = apagado;
    }

    public string getApagar()
    {
        return Status;
    }

    public void setSubirTemperatura(int masFrio)
    {
        this.Temperatura = masFrio;
    }
    public int getSubirTemperatura()
    {
        return Temperatura;
    }

    public void setBajarTemperatura(int mascalor)
    {
        this.Temperatura = mascalor;
    }
    public int getBarjarTemperatura()
    {
        return Temperatura;
    }

    public void setSubirVelocidad(int masVelocidad)
    {
        this.VelocidadFan = masVelocidad;
        if(masVelocidad > 4)
        {
            Console.WriteLine("Velocidad muy elevada, introduzca una velocidad menor..");
        }
    }
    public int getSubirVelocidad()
    {
        return VelocidadFan;
    }

    public void setBajarVelocidad(int menosVelocidad)
    {
        this.VelocidadFan = menosVelocidad;
        
    }
    public int getBajarVelociad()
    {
        return VelocidadFan;
    }

    public void estadoDelAire()
    {
        Console.WriteLine("\nMarca: {0}", Marca);
        Console.WriteLine("\nTemperatura: {0}", Temperatura);
        Console.WriteLine("\nVelocidad del fan: {0}", VelocidadFan);
        Console.WriteLine("\nStatus: {0}", Status);
    }

}

//Tester-Class

class Program
{
    public static void Main()
    {
        AireAcondicionado miAire = new AireAcondicionado("Nedoca", 15, 3, "encendido");
        miAire.estadoDelAire();

        miAire.setEncender("encendido");
        miAire.getEncender();

        if(miAire.getEncender() == "encendido")
        {
            miAire.setSubirTemperatura(23);
            miAire.getSubirTemperatura();

            miAire.setSubirVelocidad(3);
            miAire.getSubirTemperatura();

            Console.WriteLine("\t\tEstado del Aire Acondicionado");
            Console.WriteLine("\nEstado: {0}", miAire.getEncender());
            Console.WriteLine("\nTemperatura: {0}", miAire.getSubirTemperatura());
            Console.WriteLine("\nVelocidad del abanico: {0}",miAire.getSubirVelocidad());
        }

       

        

        //Segunda instancia

        AireAcondicionado apagarAire = new AireAcondicionado();
        apagarAire.setApagar("Apagado");
        apagarAire.getApagar();
        Console.WriteLine("\nEl aire acondicionado esta apagado..");

        


    }
}