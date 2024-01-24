namespace sharebuilder_server.Data;

public class Station
{
    public required string CallLetters { get; set; }

    public required string Market { get; set; }

    public required string Affiliation { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }
}
