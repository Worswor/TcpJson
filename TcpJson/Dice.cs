using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TcpOpg1;

public class Dice
{
	public int LowPip { get; set; }
	public int HighPip { get; set; }

	public Dice() { }

	public Dice (int lowPip, int highPip)
	{
		LowPip = lowPip;
		HighPip = highPip;
	}
}