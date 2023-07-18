using System.Linq.Expressions;
using Core.Entitities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class UsuarioRepository : IUsuarioInterface
{
    protected readonly CitasContext _context;
    public UsuarioRepository(CitasContext context)
    {
        _context = context;
    }
    public virtual void Add(Usuario entity)
    {
        _context.Set<Usuario>().Add(entity);
    }
    
    public virtual void AddRange(IEnumerable<Usuario> entities)
    {
        _context.Set<Usuario>().AddRange(entities);
    }

    public 
}

 
