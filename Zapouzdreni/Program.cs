class Program 
{//litr na kilometr, 40l
    public static void Main(string[] args)
    {
        Auto auto = new Auto(24);
        auto.stavPaliva();
        auto.natankuj(20);
        auto.stavPaliva();
        auto.jed(14);
        auto.stavPaliva();
        auto.natankuj(10);
        auto.stavPaliva();

    }

    public class Auto
    {
        private int palivo;
        public int Palivo
        {
            get { return palivo; }
            set
            {
                if (value > 40)
                    palivo = 40;  
                else if (value < 0)
                    palivo = 0;  
                else
                    palivo = value;
            }
        }

        public Auto(int Palivo) { 
            palivo = Palivo;
        }

        public void natankuj(int palivoNapleni)
        {
            Palivo += palivoNapleni;
            Console.WriteLine($"Naplnil jsi {palivoNapleni} litrů");
        }
        public void stavPaliva()
        {
            Console.WriteLine($"Máš {Palivo} litrů paliva");
        }
        public void jed(int vzdalenost)
        {
            Palivo -= vzdalenost;
            Console.WriteLine($"Ujel si {vzdalenost} kilometrů");
        }
    }
}