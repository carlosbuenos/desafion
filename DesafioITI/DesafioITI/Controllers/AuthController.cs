using DesafioITI.Domain;
using DesafioITI.Domain.Builder.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioITI.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IBuilderRules _builderRules;
		public AuthController(IBuilderRules builderRules)
		{
			_builderRules = builderRules;
		}

		/// <summary>
		///  Endpointe para validação de senha
		/// </summary>
		/// <param name="password"></param>
		/// <returns></returns>
		[HttpPost("PasswordValidation")]
		public ActionResult ValidatedPassword(PasswordData password)
		{
			if (password.IsValid(_builderRules))
			{
				return Ok(true);
			}

			return BadRequest(false);
		}
	}
}
