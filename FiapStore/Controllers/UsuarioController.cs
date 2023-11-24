using FiapStore.Entidade;
using FiapStore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiapStore.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;
        
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        
        [HttpGet("obter-todos-usuarios")]
        public IActionResult ObterTodosUsuarios()
        {
            return Ok(_usuarioRepository.ObterTodosUsuarios());
        }
        
        [HttpGet("obter-usuario-por-id/{id}")]
        public IActionResult ObterUsuarioPorId(int id)
        {
            return Ok(_usuarioRepository.ObterUsuarioPorId(id));
        }

        [HttpPost()]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            _usuarioRepository.CadastrarUsuario(usuario);
            return Ok("Usuário criado com sucesso");
        }

        [HttpPut()]
        public IActionResult AlterarUsuario(Usuario usuario)
        {
            _usuarioRepository.AlterarUsuario(usuario);
            return Ok("Usuario alterado com sucesso");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            _usuarioRepository.DeletarUsuario(id);
            return Ok("Usuario deletado com sucesso");
        }
    }
}

