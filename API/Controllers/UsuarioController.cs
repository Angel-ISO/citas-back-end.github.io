using Core.Entitities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
public class UsuarioController : BaseApiController
{
    private readonly CitasContext _context;
    public UsuarioController(CitasContext context)
    {
        _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Usuario>>> Get()
    {
        var user = await _context.Usuarios.ToListAsync();
        return Ok(user);
    }

}

   