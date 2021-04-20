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
			MessageBox.Show("Convert feature 1 to feature 1'.", "Caption");
			MessageBox.Show("Fix feature 1 in main", "Caption");
		}
		static void someFunction()
		{
		}
	}
}
