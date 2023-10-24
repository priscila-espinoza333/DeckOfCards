public class Mazo
{
    public List<Carta> Cartas { get; }

    public Mazo()
    {
        Cartas = new List<Carta>();
        // Inicializar el mazo con 52 cartas
        string[] pintas = { "Picas", "Tréboles", "Corazones", "Diamantes" };
        string[] nombres = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Reina", "Rey" };

        foreach (var pinta in pintas)
        {
            for (int i = 0; i < 13; i++)
            {
                var carta = new Carta(nombres[i], pinta, i + 1);
                Cartas.Add(carta);
            }
        }
    }

    public Carta Repartir(){
        //creo condición a mazo para verificar cantidad de cartas en el.
        if (Cartas.Count > 0){
            var cartaRepartida = Cartas[Cartas.Count - 1];
            Cartas.RemoveAt(Cartas.Count - 1);
            return cartaRepartida;
        }
        return null;
    }

    public void Barajar(){
        Random random = new Random();
        int n = Cartas.Count;
        while (n > 1){
            n--;
            int k = random.Next(n + 1);
            Carta carta = Cartas[k];
            Cartas[k] = Cartas[n];
            Cartas[n] = carta;
        }
    }

    public void Reiniciar(){
        Cartas.Clear();
        // creo nuevamente el mazo con 52 cartas
        string[] pintas = { "Tréboles", "Picas", "Corazones", "Diamantes" };
        string[] nombres = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Reina", "Rey" };

        foreach (var pinta in pintas){
            for (int i = 0; i < 13; i++)
            {
                var carta = new Carta(nombres[i], pinta, i + 1);
                Cartas.Add(carta);
            }
        }
    }
}