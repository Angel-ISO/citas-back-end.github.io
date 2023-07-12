# back-end para citas con c#
iniciar migraciones
'''
dotnet ef
migrations add InitialCreate --project ./Infrastructure/ --startup-project ./API/ --output-dir
./Data/Migrations
'''


actualizar base de datos

'''
dotnet ef database
update --project ./Infrastructure/ --startup-project ./API/
'''
