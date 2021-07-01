namespace DesafioITI.Service.Interfaces
{
	public interface IBuilderRules
	{
		public bool AtLessOneDigit(string Value);
		public bool AtLessOneUpperCaseLetter(string Value);
		public bool AtLeastOneLowercaseLetter(string Value);
		public bool AtLeastOneSpecialCharacter(string Value);
		public bool NoDuplicateCharacter(string Value);
		public bool HaveMinimumNineCharacters(string Value);
	}
}
