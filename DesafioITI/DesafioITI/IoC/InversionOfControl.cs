using DesafioITI.Domain.Builder.ConcreteObjects;
using DesafioITI.Domain.Builder.Interfaces;
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
