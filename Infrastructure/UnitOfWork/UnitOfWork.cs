using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork
{
    private readonly CitasContext context;
    private UsuarioRepository _Usuario;
    
public IUsuarioInterface Usuarios => new UsuarioRepository(context);

    public UnitOfWork(CitasContext _context)
    {
        context = _context;
    }

    public IUsuarioInterface Usuarios
    {
      get{
        if (_Usuario == null){
            _Usuario = new UsuarioRepository(context);
        }
        return _Usuario; 
      }
    }
   public int Save()
   {
    throw new NotImplementedException();
   }
}


