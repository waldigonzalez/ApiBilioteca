using Aplicacion.Feautres.Libros.Comandos.CrearLibro;
using Aplicacion.Feautres.Libros.Comandos.EliminarLibro;
using Aplicacion.Feautres.Libros.Comandos.ModificarLibro;
using Aplicacion.Feautres.Libros.Consultas.OptenerLibroPorId;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers.v1
{
    [ApiVersion("1.0")]
    public class LibroController : BaseApiController
    {
        //Post 
        [HttpPost]
       public async Task<IActionResult> Post(CrearLibro comando)
        {
            return Ok(await Mediator.Send(comando));
        }
         
        //Put 
        [HttpPut]
        public async Task<IActionResult> Put(int Id, ModificarLibro comando)
        {
            if (Id != comando.Id) 
                return BadRequest();
            return Ok(await Mediator.Send(comando));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id )
        {
            return Ok(await Mediator.Send(new EliminarLibro  { Id = id }));
        }

        //Get 
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new OptenerLibroId { Id = id }));
        }
    }
}

