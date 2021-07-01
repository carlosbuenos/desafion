using DesafioITI.Service.Interfaces;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DesafioITI.UnityTests
{
	public class PasswordTests
	{
		private readonly Mock<IBuilderRules> _builders;
		public PasswordTests()
		{
			_builders = new Mock<IBuilderRules>();
		}

		[Fact]
		public void Validations()
		{
			const string value = "aa";
			var resultList = new List<bool>();
			resultList.Add(_builders.Object.AtLessOneDigit(value));
			resultList.Add(_builders.Object.NoDuplicateCharacter(value));
			resultList.Add(_builders.Object.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.Object.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.Object.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.Object.HaveMinimumNineCharacters(value));

			Assert.Equal(false, resultList.Any(x => x.Equals(false)));
		}
	}
}
