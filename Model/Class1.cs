using static System.Formats.Asn1.AsnWriter;

namespace Model;

public class Standing
{
    public int Id { get; set; }
    public string name { get; set; }
    public string city { get; set; }
    public int wins { get; set; }
    public int defeats { get; set; }
    public int draws { get; set; }
    public int scoredGoals { get; set; }
    public int missedGoals { get; set; }
    public Standing(string name, string city, int wins, int defeats, int draws)
    {
        this.name = name;
        this.city = city;
        this.wins = wins;
        this.defeats = defeats;
        this.draws = draws;
    }
}