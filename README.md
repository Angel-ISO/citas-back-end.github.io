# back-end para citas con c#
iniciar migraciones

```
dotnet ef migrations add InitialCreate --project ./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations
```


publicacion en base de datos y actualizaciones posteriores
```
dotnet ef database update --project ./Infrastructure/ --startup-project ./API/
```
