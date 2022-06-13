using ConsumindoApiViaJQuery.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno() { AlunoId = 1, Nome = "Paulo" });
            alunos.Add(new Aluno() { AlunoId = 2, Nome = "Clarisse" });
            alunos.Add(new Aluno() { AlunoId = 3, Nome = "Armando" });
            alunos.Add(new Aluno() { AlunoId = 4, Nome = "Berenice" });
            alunos.Add(new Aluno() { AlunoId = 5, Nome = "Orlando" });
            return new ObjectResult(alunos);
            //return new string[] { "Maria", "Paulo", "Pedro", "Marcia", "Armando" };
        }

        [Authorize]
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Marta";
        }
    }
}
