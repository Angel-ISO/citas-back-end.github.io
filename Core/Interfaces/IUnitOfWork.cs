namespace Core.Interfaces;
public class IUnitOfWork
{
    IUsuarioInterface ?Usuario{ get; }

    int Save();
}

