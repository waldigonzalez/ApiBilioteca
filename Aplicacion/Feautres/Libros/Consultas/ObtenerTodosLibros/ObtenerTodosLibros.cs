using Aplicacion.DTOs;
using Aplicacion.Espesificasion;
using Aplicacion.Feautres.Libros.Consultas.OptenerLibroPorId;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Entidades;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Feautres.Libros.Consultas.ObtenerTodosLibros
{
    public class OptenerTodosLibroHandler : IRequest<PaginadorRespuesta<List<Librodto>>>
    {
        public int NumeroPagina { get; set; }
        public int TamanioPagina { get; set; }
        public String? TituloLibro { get; set; }



        public class ObtenerTodosLibrosHandler : IRequestHandler<OptenerTodosLibroHandler, PaginadorRespuesta<List<Librodto>>>
        {

            private readonly IRepositorioAsincrono<Libro> _repositorioAsincrono;
            private readonly IMapper _mapper;
        
        public ObtenerTodosLibrosHandler(IRepositorioAsincrono<Libro> repositorioAsincrono, IMapper mapper)
        
            {
            _repositorioAsincrono = repositorioAsincrono;
            _mapper = mapper;
        }
            public async Task<PaginadorRespuesta<List<Librodto>>> Handle(OptenerTodosLibroHandler request, CancellationToken cancellationToken)
            {
                var libros = await _repositorioAsincrono.ListAsync(new PaginaLibroEspecificacion(request.TamanioPagina, request.NumeroPagina, request.TituloLibro));
                var librodto = _mapper.Map<List<Librodto>>(libros);

                return new PaginadorRespuesta<List<Librodto>>(librodto, request.TamanioPagina, request.NumeroPagina);
            }
        }
           
            }
      
}
