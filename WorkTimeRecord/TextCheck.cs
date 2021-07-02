using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WorkTimeRecord
{
	class TextCheck
	{
		public bool CheckText(string Text)
		{
			var isJapanese = Regex.IsMatch(Text, @"[\p{IsHiragana}\p{IsKatakana}\p{IsCJKUnifiedIdeographs}]+");
			return isJapanese;
		}

		public bool CheckTextReturnMessage(string Text)
		{
			var isJapanese = false;
			if (CheckText(Text))
			{
				isJapanese = true;
				MessageBox.Show("日本語が含まれています。入力文字を確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				isJapanese = false;
			}
			return isJapanese;
		}

		public bool CheckTextReturnMessage(string Text, string Text2)
		{
			var isJapanese = false;
			if (CheckText(Text) || CheckText(Text2))
			{
				isJapanese = true;
				MessageBox.Show("日本語が含まれています。入力文字を確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				isJapanese = false;
			}
			return isJapanese;
		}

		public bool CheckTextContainsNumber(string Text)
		{
			var isContainsnum = false;

			if (Text.Any(char.IsDigit))
			{
				isContainsnum = true;
				MessageBox.Show("数字が含まれています。入力文字を確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				isContainsnum = false;

			return isContainsnum;
		}
	}
}
