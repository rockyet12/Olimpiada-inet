using Microsoft.AspNetCore.Mvc;
using SportStyle.Application.Services;

namespace SportStyle.Presentation.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [Produces("application/json")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _context;
        public ClienteController(IClienteService clienteService)
        {
            _context = clienteService;
        }

        [HttpPost]
        public async Task<IActionResult> IniciarSesion([FromBody] LoginModel cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var email = await _context.GetClienteMail(cliente.Email);
                var pass = await _context.GetClientePass(cliente.Password);
                if (email.Count == 0 || pass.Count == 0)
                {
                    return BadRequest("No se encontró");
                }
                else
                {
                    RedirectToAction("/");
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
    public class LoginModel
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
