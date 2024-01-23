namespace sharebuilder_server.Data;

public class StationService
{
    private List<Station> Stations = new List<Station>
    {
        new Station { CallLetters = "KTLA-TV", Market = "Los Angeles", Affiliation = "CW" },
        new Station { CallLetters = "KABC-TV", Market = "Los Angeles", Affiliation = "ABC" },
        new Station { CallLetters = "KCBS-TV", Market = "Los Angeles", Affiliation = "CBS" },
        new Station { CallLetters = "KNBC", Market = "Los Angeles", Affiliation = "NBC" },
    };

    public Task<List<Station>> GetStationsAsync()
    {
        return Task.FromResult(Stations);
    }
}

