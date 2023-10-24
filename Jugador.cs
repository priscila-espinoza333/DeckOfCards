public class Jugador
{
    public string Nombre { get; }
    public List<Carta> Mano { get; }

    public Jugador(string nombre){
        Nombre = nombre;
        Mano = new List<Carta>();
    }

    public Carta Robar(Mazo mazo){
        var cartaRepartida = mazo.Repartir();
        if (cartaRepartida != null){
            Mano.Add(cartaRepartida);
        }
        return cartaRepartida;
    }

    public Carta Descartar(int indice){
        if (indice >= 0 && indice < Mano.Count){
            var cartaDescartada = Mano[indice];
            Mano.RemoveAt(indice);
            return cartaDescartada;
        }
        return null;
    }
}