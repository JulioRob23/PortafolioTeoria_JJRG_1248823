using System;
class Cafetera
{
    int codigo;
    int capacidad, disponibles;
    bool lleno;
    // hacer cafe
    private void hacerCafe ()
    {
        lleno = true;
        disponibles = capacidad; 
    }

    //servrir taza
    public void servirTaza (int cantTazas)
    {
        if ( disponibles >= cantTazas)
        {
            disponibles = disponibles - cantTazas;
        }
        else
        {
            Console.WriteLine("No tenemos suficientes tazas disponibles");
        }
    }

    //obtener porcenteaje de disponibilidad 
    public double obtenerPorcentaje()
    {
        double porcentaje = ((double)disponibles / capacidad) * 100; 
        return porcentaje;
    }

    //mostrar estado 
    public void mostrarEstado()
    {
        string texto = codigo + " capacidad:" + capacidad + "Tazas servida: " + (capacidad - disponibles) +
            "porcentaje: " + obtenerPorcentaje() + "%"; 
        Console.WriteLine(texto);
    }
    // constructor 
    public Cafetera(int elCodigo, int laCapacidad)
    {
        codigo = elCodigo;
        capacidad = laCapacidad;
        lleno = false;
        disponibles = 0;
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese capacidad de cafetera");
        int cap = Convert.ToInt32(Console.ReadLine());
        string opcion = "";
        Cafetera cafe = new Cafetera(1,cap);
        
        cafe.hacerCafe();
        do
        {
            Console.WriteLine("Cuantas tazas quiere servir?");
            int tz = Convert.ToInt32(Console.ReadLine());

            cafe.servirTaza(tz);
            cafe.mostrarEstado();

            Console.WriteLine("Desea ingresar mas tazas? s/n");
            opcion = Console.ReadLine().ToLower();
        } while (opcion == "s");
        
    }
}