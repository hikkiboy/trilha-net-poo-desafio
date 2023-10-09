namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
         public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalou {nomeApp} no Nokia");
        }
    }
}