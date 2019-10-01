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

	var results = from x in Albums
where x.Tracks.Count() > 0
select new
{
	title = x.Title,
	artist = x.Artist.Name,
	trackcount=x.Tracks.Count(),
	playtime=x.Tracks.Sum(z=> z.Milliseconds),
	tracks = from y in x.Tracks
			 select new
			 {
			 	song = y.Name,
				genre = y.Genre.Name,
				length = y.Milliseconds
			 }

}; results.Dump();

}

// Define other methods and classes here

public class TrackPOCO
{
  public string songName {get;set;}
  public string SongGenre {get;set;}
  public string songLength {get;set;}

}

public class AlbumDTO
{
  public string AlbumTitle{get;set;}
  public string AlbumArtist {get;set;}
  public int TrackCount {get;set;}
  public int PlayTime {get;set;}
  public List
}
