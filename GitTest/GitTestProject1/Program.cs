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
			AnotherMessage("This is release message");
			
		}
		static void AnotherMessage(string m)
		{
			MessageBox.Show(m, "Caption");
		}
	}
}
