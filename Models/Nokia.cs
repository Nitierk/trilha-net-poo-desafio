namespace DesafioPOO.Models
{

    public sealed class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write($"Instalando alicativo {nomeApp} no Nokia!");
        }
    }
}