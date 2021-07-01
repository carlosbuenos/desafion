using DesafioITI.Service.ConcreteObjects;
using DesafioITI.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioITI.Api.IoC
{
	public static class InversionOfControl
	{
		public static void AddInjections(this IServiceCollection services) {

			services.AddSingleton<IBuilderRules, BuilderRules>();
		}
	}
}
