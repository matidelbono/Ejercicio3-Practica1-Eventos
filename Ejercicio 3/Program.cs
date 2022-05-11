using System;
using System.Timers;
using logica;
internal class Program
{
    static void Main(string[] args)
    {
        Reloj reloj=new Reloj();
        reloj.Horario();

    }
    static void HorarioRealizadoHandler(object? sender, MuestraEventArgs e)
    {
        Console.WriteLine("Son las" + e.horario);

    }
}

