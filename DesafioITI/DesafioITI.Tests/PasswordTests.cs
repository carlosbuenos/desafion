using DesafioITI.Domain.Builder.ConcreteObjects;
using DesafioITI.Domain.Builder.Interfaces;
using System.Collections.Generic;
using Xunit;

namespace DesafioITI.Tests
{

	public class PasswordTests
	{
		private readonly IBuilderRules _builders;
		public PasswordTests()
		{
			_builders = new BuilderRules();
		}

		[Fact]
		public void ValidationsFalse_1()
		{
			const string value = "";
			var resultList = new List<bool>();
			resultList.Add(_builders.AtLessOneDigit(value));
			resultList.Add(_builders.NoDuplicateCharacter(value));
			resultList.Add(_builders.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.HaveMinimumNineCharacters(value));

			Assert.Equal(false,!resultList.Contains(false));
		}


		[Fact]
		public void ValidationsFalse_2()
		{
			const string value = "aa";
			var resultList = new List<bool>();
			resultList.Add(_builders.AtLessOneDigit(value));
			resultList.Add(_builders.NoDuplicateCharacter(value));
			resultList.Add(_builders.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.HaveMinimumNineCharacters(value));

			Assert.Equal(false, !resultList.Contains(false));
		}

		[Fact]
		public void ValidationsFalse_3()
		{
			const string value = "ab";
			var resultList = new List<bool>();
			resultList.Add(_builders.AtLessOneDigit(value));
			resultList.Add(_builders.NoDuplicateCharacter(value));
			resultList.Add(_builders.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.HaveMinimumNineCharacters(value));

			Assert.Equal(false, !resultList.Contains(false));
		}

		[Fact]
		public void ValidationsFalse_4()
		{
			const string value = "AAAbbbCc";
			var resultList = new List<bool>();
			resultList.Add(_builders.AtLessOneDigit(value));
			resultList.Add(_builders.NoDuplicateCharacter(value));
			resultList.Add(_builders.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.HaveMinimumNineCharacters(value));

			Assert.Equal(false, !resultList.Contains(false));
		}

		[Fact]
		public void ValidationsFalse_5()
		{
			const string value = "AbTp9!foo";
			var resultList = new List<bool>();
			resultList.Add(_builders.AtLessOneDigit(value));
			resultList.Add(_builders.NoDuplicateCharacter(value));
			resultList.Add(_builders.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.HaveMinimumNineCharacters(value));

			Assert.Equal(false, !resultList.Contains(false));
		}

		[Fact]
		public void ValidationsFalse_6()
		{
			const string value = "AbTp9!foA";
			var resultList = new List<bool>();
			resultList.Add(_builders.AtLessOneDigit(value));
			resultList.Add(_builders.NoDuplicateCharacter(value));
			resultList.Add(_builders.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.HaveMinimumNineCharacters(value));

			Assert.Equal(false, !resultList.Contains(false));
		}
		[Fact]
		public void ValidationsFalse_7()
		{
			const string value = "AbTp9 fok";
			var resultList = new List<bool>();
			resultList.Add(_builders.AtLessOneDigit(value));
			resultList.Add(_builders.NoDuplicateCharacter(value));
			resultList.Add(_builders.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.HaveMinimumNineCharacters(value));

			Assert.Equal(false, !resultList.Contains(false));
		}

		[Fact]
		public void ValidationsTrue_1()
		{
			const string value = "AbTp9!fok";
			var resultList = new List<bool>();
			resultList.Add(_builders.AtLessOneDigit(value));
			resultList.Add(_builders.NoDuplicateCharacter(value));
			resultList.Add(_builders.AtLeastOneLowercaseLetter(value));
			resultList.Add(_builders.AtLeastOneSpecialCharacter(value));
			resultList.Add(_builders.AtLessOneUpperCaseLetter(value));
			resultList.Add(_builders.HaveMinimumNineCharacters(value));

			Assert.Equal(true, !resultList.Contains(false));
		}
	}
}
