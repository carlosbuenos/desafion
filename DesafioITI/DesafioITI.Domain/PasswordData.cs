using DesafioITI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioITI.Domain
{
	public class PasswordData
	{
		public string Password { get; set; }
		private List<bool> ListRules { get; set; }

		public PasswordData()
		{
			ListRules = new List<bool>();
		}

		public bool IsValid(IBuilderRules rules)
		{
			ListRules.Add(rules.AtLessOneDigit(Password));
			ListRules.Add(rules.AtLessOneUpperCaseLetter(Password));
			ListRules.Add(rules.AtLeastOneLowercaseLetter(Password));
			ListRules.Add(rules.NoDuplicateCharacter(Password));
			ListRules.Add(rules.AtLeastOneSpecialCharacter(Password));
			ListRules.Add(rules.HaveMinimumNineCharacters(Password));

			return ListRules.Contains(false) ? false : true;
		}


	}
}
