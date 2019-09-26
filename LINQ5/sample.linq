<Query Kind="Expression">
  <Connection>
    <ID>65e8e5c8-8137-4a00-989c-ee68b541e724</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

// sample of query extax to show the artists data
from x in Artists 
select x

// sample of method of to  show the artists data
Artists
   .Select (x => x)
   
//sort datainfo.sort(x,y)=> x,Attri
from x in Artists where x.Name.Contains("son") select x

Artists.Where(x=>x.Name.Contains("son")).Select(x=>x)


//create a list of Album release in 1970

Albums.Where(x=>x.ReleaseYear ==1970).Select(x=>x)


from x in Albums where x.ReleaseYear ==1970 orderby x.Title select x

//create a list the album release between 2007 and 2018 orderby release year by title 

from x in Albums where x.ReleaseYear >=2007 && x.ReleaseYear <=2018 orderby x.Title select x

// another way to create a list 
Albums.Where(x=>x.ReleaseYear >=2007 && x.ReleaseYear<=2018).OrderBy(x=>x.Title)

// can navigational property bu used in queries
from x in Albums where x.Artist.Name.Contains("Deep Purple") orderby x.ReleaseYear, x.Title select x

// can customize the label by use  select new {}  
from x in Albums where x.Artist.Name.Contains("Deep Purple") orderby x.ReleaseYear, x.Title select new 
{ Title = x.Title, ArtistName = x.Artist.Name, Year = x.ReleaseYear , Label = x.ReleaseLabel }




