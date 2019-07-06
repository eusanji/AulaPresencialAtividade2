using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CepApp.Models;
using WebService.Models;

namespace CepApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly Context _context;

        public EnderecoController(Context context)
        {
            _context = context;
        }

        // GET: api/Endereco
        [HttpGet("Enderecos")]
        public IEnumerable<CEP> GetCEP()
        {
            return _context.CEP;
        }

        // GET: api/Endereco/82000-000
        [HttpGet("Enderecos/"+"{cep}")]
        public CEP Enderecos(string cep)
        {
            return _context.CEP.Where(e => e.Cep == cep).FirstOrDefault();
        }

        // GET: api/Endereco/EnderecoPorEstado/UF
        [HttpGet("EnderecoPorEstado/"+"{uf}")]
        public ActionResult<IEnumerable<CEP>> EnderecosPorEstado (string uf) 
        {
            return _context.CEP.Where(e => e.Uf == uf).ToList();
        }

    }
}