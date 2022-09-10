<Query Kind="Statements">
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

//this environment expects the use of c# statement grammar 
//the results of a query is not automatically displayed as in the expression enviroment 
// to display the results yu need to .Dump() the variable holding the data result 

////>Dump() IS A LINQPAD METHOD . IT IS NOT A C# METHOD
// within the statement environment one can run all the queries in one execution 


var qsyntaxlist = from arowoncollection in Albums
                 select arowoncollection;
//qsyntaxlist.Dump();

var msyntaxlist = Albums
                 .Select(arowoncollection=> arowoncollection)
				 .Dump();
//msyntaxlist.Dump();

var QueenAlbums = Albums
    .Where(a=> a.Artist.Name.Contains("Queen"))
	.Dump();

