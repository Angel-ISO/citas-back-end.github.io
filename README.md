# back-end para citas con c#
iniciar migraciones
```c#
dotnet ef
migrations add InitialCreate --project ./Infrastructure/ --startup-project ./API/ --output-dir
./Data/Migrations
```


actualizar base de datos

```c#
dotnet ef database
update --project ./Infrastructure/ --startup-project ./API/
```
