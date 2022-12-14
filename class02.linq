<Query Kind="Expression">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c12aaaaa</ID>
    <NamingService>2</NamingService>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\ChinookDemoDb.sqlite</AttachFileName>
    <DisplayName>Demo database (SQLite)</DisplayName>
    <DriverData>
      <PreserveNumeric1>true</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.Sqlite</EFProvider>
      <MapSQLiteDateTimes>true</MapSQLiteDateTimes>
      <MapSQLiteBooleans>true</MapSQLiteBooleans>
    </DriverData>
  </Connection>
</Query>

//sorting

//there is a difference between query syntax and method syntax

//query syntax is much like sql 
// orderby  (no space) field {[ascending]/[descending]}[,field....]

// ascending is the default option

//method syntax is the series of individual methods

//.OrderBy (x=>x.field)first field only
//.OrderByDescending(x=x.field) each following field
//.ThenBy(x=>x.field)  first field only
//.ThenByDescending(x=>x.field)  each following field



// find all of the album tracks for the band Queen.  order the track by track namme alphabetically

// query syntax

from x in Tracks
where x.Album.Artist.Name.Contains("Queen")
orderby x.AlbumId,x.Name
select x



//method syntax



Tracks
.Where (x=> x.Album.Artist.Name.Contains("Queen"))
.OrderBy(x=>x.AlbumId)
.ThenBy(x=>x.Name)
   // sort by ablum name  ..... go to associated album 
   
 Tracks
.Where (x=> x.Album.Artist.Name.Contains("Queen"))
.OrderBy(x=>x.Album.Title)//// navigational proprtty
.ThenBy(x=>x.Name)


// sorting and filtering can be in any order, results will be same

 Tracks

.OrderBy(x=>x.Album.Title)//// navigational proprtty
.ThenBy(x=>x.Name)
.Where (x=> x.Album.Artist.Name.Contains("Queen"))


