class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("\nCreando un mazo:");
        //creo la instancia de mazo y almaceno variable
        Mazo mazo = new Mazo();
        //reordeno el mazo para cambiar el orden de este
        mazo.Barajar();
        //creo ciclo forech para recorrer las cartas del mazo
        foreach (var carta in mazo.Cartas){
            carta.Imprimir();
        }

        Console.WriteLine("\nRepartiendo cartas:");
        //creo ciclo for para repartir 5 cartas
        for (int i = 0; i < 5; i++){
            Carta cartaRepartida = mazo.Repartir();
            cartaRepartida.Imprimir();
        }

        Console.WriteLine("\nReiniciando el mazo:");
        //llamo al metodo del objeto reiniciando el mazo de 52 cartas
        mazo.Reiniciar();
        foreach (var carta in mazo.Cartas){
            carta.Imprimir();
        }

        Console.WriteLine("\nCreando un jugador:");
        //creo la instancia de jugador
        Jugador jugador = new Jugador("Jugador1");

        Console.WriteLine("\nRobando cartas:");
        for (int i = 0; i < 3; i++){
            Carta cartaRobada = jugador.Robar(mazo);
            cartaRobada.Imprimir();
        }

        Console.WriteLine("\nMano del jugador:");
        foreach (var carta in jugador.Mano){
            carta.Imprimir();
        }

    }
}