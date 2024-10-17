using PROJECT.BlackJack;

public class Card : ICard
{
    public string Suit { get; private set; }
    public string Rank { get; private set; }

    public static List<string> Suits = new List<string> { "♥", "♦", "♣", "♠" };
    public static List<string> Ranks = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    public Card(string rank, string suit)
    {
        Rank = rank;
        Suit = suit;
    }

    // Возвращение очков соответствующих карт 
    public int Value
    {
        get
        {
            if (Rank == "J" || Rank == "Q" || Rank == "K")
            {
                return 10;
            }
            else if (Rank == "A")
            {
                return 11;
            }
            else
            {
                return int.Parse(Rank);
            }
        }
    }

    // Отображение масти и ранга
    public override string ToString()
    {
        return $"{Rank} {Suit}";
    }
}
