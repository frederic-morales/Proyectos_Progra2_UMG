// See https://aka.ms/new-console-template for more information
using FigurasGeometricas;

Triangulo triangulo = new Triangulo();
triangulo.Nombre = "Primer Triangulo";
triangulo.Clasificacion = "isosceles";
triangulo.Base = 8.3;
triangulo.Altura = 14.1;

Console.WriteLine(triangulo.area);
