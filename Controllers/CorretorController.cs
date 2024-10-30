using CadastroCorretora.DB;
using CadastroCorretora.Model;
using Microsoft.AspNetCore.Mvc;
using CadastroCorretora.Autenticacao_Jwt;

namespace CadastroCorretora.Controllers
{
    public class CorretorController:ControllerBase
    {

        private readonly GerarToken _gerarToken;
        private readonly CorretoraContext _contextCorretor;
       

        public CorretorController(CorretoraContext context, GerarToken gerarToken)
        {

            _contextCorretor = context;
            _gerarToken = gerarToken;

        }



        [HttpPost("Corretor")]
        public async Task<ActionResult<Corretor>>
               PostCorretor(Corretor cadastro,CorretoraCadastro cadastroCorretora)
        {
            
            _contextCorretor.Corretores.Add(cadastro);
            await _contextCorretor.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCorretor), new { id = cadastro.idCorretor }, cadastro);
        }



        [HttpGet("Corretor")]
        public async Task<ActionResult<Corretor>>
        GetCorretor(int id)
        {
            var cnpjCorretor = await _contextCorretor.Corretores.FindAsync(id);

            if (cnpjCorretor == null)
            {
                return NotFound();
            }

            var autorizacao = _gerarToken.TokenAutenticacao();


            return Ok(new { Token = autorizacao,cnpjCorretor });
        }




    }
}

