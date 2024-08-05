using System;

public class Triangulo
{
    public decimal Altura { get; set; }
    public decimal B { get; set; }

    public decimal ObtenerMedidas()
    {
        decimal area;
        area = Altura * B / 2;
        return area;
    }

    public void Imprimir(decimal area)
    {
        Console.WriteLine($"El tamaño del triángulo es = {area}");
    }
}


public class Cuadrado
{
    public decimal Lados { get; set; }

    public decimal ObtenerResultado()
    {
        decimal Cuadro;
        Cuadro = Lados * 2;
        return Cuadro;
    }

    public void Imprimir(decimal Cuadro)
    {
        Console.WriteLine($"el tamaño del cuadro es = {Cuadro}");

    }
}


public class Rectangulo
{
    public decimal Base { get; set; }
    public decimal Altura { get; set; }

    public decimal ObtenerArea()
    {
        decimal Medidas;
        Medidas = Base * Altura;
        return Medidas;
    }


    public void Imprimir(decimal Medidas)
    {
        Console.WriteLine($" el tamaño de el rectangulo es =  {Medidas}");
    }
}

public class Rombo
{
    public decimal Diagonal { get; set; }
    public decimal Lado { get; set; }

    public decimal ObtenerResultado()
    {
        decimal Medidas;
        Medidas = Diagonal * Lado / 2;
        return Medidas;

    }

    public void Imprimir(decimal Medidas)
    {
        Console.WriteLine($"la medida de el rombo es = {Medidas}");
    }
}

public class Circulo
{
    public double Radio { get; set; }

    public double ObtenerRadio()
    {
        double Resultado;
        Resultado = 3.14 * Radio * Radio;
        return Resultado;

    }

    public void Imprimir(double Resultado)
    {
        Console.WriteLine($"el resultado del radio del circulo es = {Resultado}");
    }
}


public class Pentagono
{
    public decimal Perimetro { get; set; }
    public decimal Area { get; set; }

    public decimal ObtenerResultado()
    {
        decimal Medidas;
        Medidas = Perimetro * Area / 2;
        return Medidas;
    }

    public void Imprimir(decimal Medidas)
    {
        Console.WriteLine($"el tamaño del pentagono es = {Medidas}");
    }
}


public class Trapecio
{
    public decimal Basemayor { get; set; }
    public decimal Basemenor { get; set; }
    public decimal Altura { get; set; }

    public decimal ObtenerRespuesta()
    {
        decimal Medidas;
        Medidas = Basemayor + Basemenor / 2 * Altura;
        return Medidas;
    }


    public void Imprimir(decimal Area)
    {
        Console.WriteLine($"el tamaño del trapecio es = {Area}");
    }

    public class Romboide
    {
        public decimal Base { get; set; }
        public decimal Altura { get; set; }

        public decimal ObtenerRespuesta()
        {
            decimal Medidas;
            Medidas = Base * Altura;
            return Medidas;
        }

        public void Imprimir(decimal Medidas)
        {
            Console.WriteLine($"el tamaño del romboide es = {Medidas}");
        }

    }


    public class Programa
    {
        public static void Main()
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 20;
            triangulo.B = 10;

            Cuadrado cuadro = new Cuadrado();
            cuadro.Lados = 5;

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base = 10;
            rectangulo.Altura = 20;

            Rombo rombo = new Rombo();
            rombo.Diagonal = 10;
            rombo.Lado = 70;

            Circulo circulo = new Circulo();
            circulo.Radio = 10;

            Pentagono pentagono = new Pentagono();
            pentagono.Perimetro = 10;
            pentagono.Area = 10;

            Trapecio trapecio = new Trapecio();
            trapecio.Basemayor = 10;
            trapecio.Basemenor = 20;
            trapecio.Altura = 20;

            Romboide romboide = new Romboide();
            romboide.Base = 10;
            romboide.Altura = 20;






            decimal area = triangulo.ObtenerMedidas();
            triangulo.Imprimir(area);

            decimal lados = cuadro.ObtenerResultado();
            cuadro.Imprimir(lados);


            decimal Medidas = rectangulo.ObtenerArea();
            rectangulo.Imprimir(Medidas);


            decimal medidas = rombo.ObtenerResultado();
            rombo.Imprimir(Medidas);

            double resultado = circulo.ObtenerRadio();
            circulo.Imprimir(resultado);

            decimal medi = pentagono.ObtenerResultado();
            pentagono.Imprimir(Medidas);

            decimal rep = trapecio.ObtenerRespuesta();
            trapecio.Imprimir(Medidas);

            decimal re = romboide.ObtenerRespuesta();
            romboide.Imprimir(Medidas);

        }
    }
}