<Query Kind="Program">
  <Connection>
    <ID>65e8e5c8-8137-4a00-989c-ee68b541e724</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

void Main()
{
	var result =from x in Albums where x.Artist.Name.Contains("Deep Purple") orderby x.ReleaseYear, x.Title select new AlbumOfArtist
{ Title = x.Title, ArtistName = x.Artist.Name, Year = x.ReleaseYear , Label = x.ReleaseLabel };
result.Dump();
}

// Define other methods and classes here
public class AlbumOfArtist
{
    public string Title{get;set;}
	public string ArtistName{get;set;}
	public int Year{get;set;}
	public string Label{get;set;}
}
