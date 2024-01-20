namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo,string imei,int memoria) : base(numero)
        {
            Console.WriteLine("Nokia " + numero);
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine("Instalado " + nomeApp);
        }

    }
}