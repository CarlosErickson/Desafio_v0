using Desafio_v0.Models;
using Desafio_v0.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_v0.Controllers
{
    [Route("api")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> Get()
        {
            var pessoas = _service.GetPessoas();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public ActionResult<Pessoa> GetById(int id)
        {
            bool item_exists = _service.PessoaExists(id);
            if (!item_exists)
                return NotFound();
            var pessoa = _service.GetPessoa(id);
            return Ok(pessoa);
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create([FromBody] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                if(pessoa == null)
                {
                    return NotFound();
                }
                _service.AddPessoa(pessoa);
                return CreatedAtAction("Create", pessoa);
                
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        [Route("update")]
        public ActionResult Update([FromBody]Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _service.UpdatePessoa(pessoa);
            return CreatedAtAction("Update", pessoa);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool item_exists = _service.PessoaExists(id);
            if (!item_exists)
                return NotFound();
            _service.DeletePessoa(id);
            return Ok();
        }
    }
}
