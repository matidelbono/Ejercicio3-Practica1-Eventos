namespace logica
{
    public class Reloj
    {
        EventHandler<MuestraEventArgs> HorarioMostrado;
        public string Hh { get; set; }
        public string Mm { get; set; }
        public string ss { get; set; }
        public string Horario ()
        {
            string horario= $"{Hh}: {Mm} :{ss}";
            if (this.HorarioMostrado!=null)
            {
                this.HorarioMostrado(this, new MuestraEventArgs() { horario = horario });
                return horario;
            }
            return "";

    }
}
}
