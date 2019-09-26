<Query Kind="Statements">
  <Connection>
    <ID>65e8e5c8-8137-4a00-989c-ee68b541e724</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

//when use the C# statments your work use need to confirm t o c# statment systax 
//ie datatype  variable = Experssion 

var result =from x in Albums where x.Artist.Name.Contains("Deep Purple") orderby x.ReleaseYear, x.Title select new 
{ Title = x.Title, ArtistName = x.Artist.Name, Year = x.ReleaseYear , Label = x.ReleaseLabel };
result.Dump();

// to display the contants of a variable in linqpad use the method . Dump() this method is only use in linqpad, is not a c# method 

