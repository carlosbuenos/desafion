using DesafioITI.Service.Interfaces;
using System.Text.RegularExpressions;

namespace DesafioITI.Service.ConcreteObjects
{
	public class BuilderRules : IBuilderRules
	{
		private Regex _rule;
		

		public bool AtLeastOneLowercaseLetter(string Value)
		{
			_rule = new Regex(@"(?=.*[a-z])");
			return _rule.IsMatch(Value);
		}

		public bool AtLeastOneSpecialCharacter(string Value)
		{
			_rule = new Regex(@"(.*[!@#$%^&*()-+^&*()/\\])");
			return _rule.IsMatch(Value);
		}

		public bool AtLessOneDigit(string Value)
		{
			return string.IsNullOrEmpty(Value) ? false : true;
		}

		public bool AtLessOneUpperCaseLetter(string Value)
		{
			_rule = new Regex(@"(?=.*[A-Z])");
			return _rule.IsMatch(Value);
		}

		public bool HaveMinimumNineCharacters(string Value)
		{
			
			_rule = new Regex(@"(.{9,})");
			var haveMinimum = _rule.IsMatch(Value);
			return haveMinimum;
		}

		public bool NoDuplicateCharacter(string Value)
		{
			_rule = new Regex(@"(\w)*.*\1");
			var haveDuplicity = _rule.IsMatch(Value);
			return haveDuplicity ? false : true;
		}
	}
}
