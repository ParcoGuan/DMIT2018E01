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



var customerList = from x in Customers where x.Country.Equals("USA") && x.Email.Contains("Yahoo") orderby x.LastName,x.FirstName select new YahooCustomers 

{
Name = x.LastName +"," + x.FirstName,
city = x.City,
state = x.State,
Email = x.Email
};
customerList.Dump();


var whosang = from x in Tracks where x.Name.Equals("Rag Doll") select new 
{
ArtistsName = x.Album.Artist.Name,
AlbumTitle = x.Album.Title,
AlbumYear = x.Album.ReleaseYear,
AlbumLabel = x.Album.ReleaseLabel,
comper = x.Composer


};
whosang.Dump();
}



public class YahooCustomers
{
public string Name{get;set;}
	public string city{get;set;}
	public string state{get;set;}
	public string Email{get;set;}

}







// Define other methods and classes here
public class AlbumOfArtist
{
    public string Title{get;set;}
	public string ArtistName{get;set;}
	public int Year{get;set;}
	public string Label{get;set;}
}








