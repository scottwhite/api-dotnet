Eval vs TS usage

TS adds build checks of what's being used. However it gives you none of a typed langs performance.

Eval a typed lang to see if it offers more

.net core 
OS: linux, mac, windows
linux: http://legendminds.in/how-to-run-net-core-console-app-on-linux/
delivery: package(s)
docker: yes
kafka: yes
API: .net mvc, kesterl for speed 
HTTP:
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel?view=aspnetcore-3.1
Redis: yes
db access: 
https://github.com/StackExchange/Dapper
package manger: yes, dotnet cli



https://medium.com/@berkayyerdelen/building-restful-api-with-dapper-and-asp-net-core-37e6d9d1bdda

early confusion: struct vs class for modeling the data coming back

Battling:
Like java this uses dependeny injection and if you don't know the correct sequence to inject stuff you are boned
Hence this project being boned
https://github.com/scottwhite/api-dotnet

What's to like:
dotnet cli does the packagemangement and building, pretty solid from limited interactions.
webapi seems fairly clean, no configurations needed on routes, self defined
dapper -> simple interface to call postgres
C# is clean and the Dao/Model pattern is well represented in dotnet land


What's not to like:
DI, I could not figure the magic out to get 
1. Logging to work in model
2. DB connection string (let alone get an obj)


Ltree support sucks
https://github.com/npgsql/npgsql/issues/699