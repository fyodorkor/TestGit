using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTestProject1
{
	class Program
	{
		static void Main(string[] args)
		{
			MessageBox.Show("Message box from master branch. Other user edited message", "Main branch caption");
			AnotherMessage();
			
		}
		static void AnotherMessage()
		{
			MessageBox.Show("added feature 1, and fixed some bugs.", "Caption");

			MessageBox.Show("Fix feature 1 in main", "Caption");
		}
		static void someFunction()
		{
		}
	}
}
