using System;

class Libro
{
    int correlativo;
    string nombre;
    int Nopags, total;
    double porcentajeleido; 
    bool leido;

    public void LeerLibro()
    {
        leido = false;
        total = Nopags; 

    }

    public void LeercantPaginas(int cantidadpags)
    {
        if(total >= cantidadpags)
        {
            total = total - cantidadpags;
        }
        else
        {
            Console.WriteLine("Error: el libro no tiene tantas páginas");
        }
    }

    public double ObtenerPorcentaje()
    {
        double porcentaje = ((double)total / Nopags) * 100; 
        porcentajeleido = porcentaje;
        return porcentaje;
    } 

    public int PaginaActual()
    {
        int pagac = total;  
        return pagac;
    }
    public void Obtenerestado()
    {
        if (porcentajeleido == 100)
        {
            leido = true;
        }
        else
        {
            leido = false;
        }
    }
    public void MostrarInfo()
    {
        string texto = nombre + "  Páginas por leer: " + total + " Páginas leídas " + (Nopags - total) + " Porcentaje por leer: " + ObtenerPorcentaje() + "%";
        Console.WriteLine(texto);
    }
    public Libro (int elTotal, string elNombre)
    {
        Nopags = elTotal;
        leido = false; 
        nombre = elNombre;

    }
    public static void Main()
    {
        Console.WriteLine("Ingrese el nombre del libro");
        string nombrelibro = Console.ReadLine();
        Console.WriteLine("Ingrese el número de páginas que contiene el libro");
        int cap = Convert.ToInt32(Console.ReadLine());
        
        string seguir = "";
        Libro libros = new Libro(cap,nombrelibro);

        libros.LeerLibro();
        do
        {
            Console.WriteLine("Cuantas páginas desea leer");
            int pal = Convert.ToInt32(Console.ReadLine());

            libros.LeercantPaginas(pal);
            libros.MostrarInfo();

            Console.WriteLine("Desea leer más páginas? s/n");
            seguir = Console.ReadLine().ToLower();
        } while (seguir == "s");

    }
}