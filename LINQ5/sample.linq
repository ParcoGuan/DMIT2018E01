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