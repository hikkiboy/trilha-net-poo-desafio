namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string _modelo;
        protected string _IMEI;

        protected int _memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {   // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            _modelo = modelo;
            _IMEI = imei;
            _memoria = memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}