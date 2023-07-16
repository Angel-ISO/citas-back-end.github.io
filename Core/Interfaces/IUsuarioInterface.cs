using System.Collections;
using System.Linq.Expressions;
using Core.Entitities;

namespace Core.Interfaces;
public interface IUsuarioInterface
{
     Task<Usuario>? GetUsuarioAsync(int id);
     Task <IEnumerable<Usuario>> GetAllAsync();
     IEnumerable<Usuario> Find(Expression<Func<Usuario,bool>> expression);
     void Add (Usuario entity);
     void AddRange (IEnumerable<Usuario> entities);
     void Remove (Usuario entity);
     void RemoveRange (IEnumerable<Usuario> entities);
     void Update (Usuario entity);
}
