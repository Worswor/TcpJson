using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpJson
{
	public class NumberTable
	{
		public int FirstNr {  get; set; }
		public int LastNr { get; set; }

		public NumberTable() { }

		public NumberTable(int firstNr, int lastNr)
		{
			FirstNr = firstNr;
			LastNr = lastNr;
		}
	}
}