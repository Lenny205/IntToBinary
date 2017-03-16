using System;
using System.Windows;

namespace IntToBinary
{
	/// <summary>
	/// Created by: Leander Dumas
	/// </summary>
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public int GetInput()
		{
			int input = 0;
			try
			{
				input = Convert.ToInt32(inputTextBox.Text);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				MessageBox.Show(Convert.ToString(e));
			}

			return input;
		}

		public void SetOutput(string output)
		{
			outputLabel.Content = output;
		}

		public string ConvertToBinary(int toConvert)
		{
			string output = null;
			while (toConvert >= 0)
			{
				if (toConvert % 2 > 0)
				{
					output += "1";
				}
				else
				{
					output += "0";
				}

				toConvert = toConvert / 2;

				if (toConvert == 0)
				{
					break;
				}
			}

			return output;
		}

		public string ReverseString(string toReverse)
		{
			char[] charArray;
			try
			{
				charArray = toReverse.ToCharArray();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				MessageBox.Show(Convert.ToString(e));
				return "0";
			}

			Array.Reverse(charArray);
			return new string(charArray);
		}

		private void convertButton_Click(object sender, RoutedEventArgs e)
		{
			var input = GetInput();
			var binary = ConvertToBinary(input);
			var output = ReverseString(binary);
			SetOutput(output);
		}
	}
}
