<Query Kind="Expression">
  <Connection>
    <ID>65e8e5c8-8137-4a00-989c-ee68b541e724</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

//create a list of all album contain the album title and artist 
//along with all the tracks (song name, genre, length) of that album 

from x in Albums
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

}

from x in Albums
select new
{
	title = x.Title,
	artist = x.Artist.Name,
	tracks = from y in Tracks
			where x.AlbumId == y.AlbumId
			 select new
			 {
			 	song = y.Name,
				genre = y.Genre.Name,
				length = y.Milliseconds
			 }

}