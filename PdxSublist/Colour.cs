using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdxUtil
{
	public class Colour
	{
		public byte Red { get; set; }
		public byte Green { get; set; }
		public byte Blue { get; set; }

		public Colour(byte r, byte g, byte b)
		{
			Red = r;
			Green = g;
			Blue = b;
		}


		public Colour(List<float> rgb)
		{

			byte r;
			byte g;
			byte b;
			if (byte.TryParse(rgb[0].ToString(), out r) && byte.TryParse(rgb[1].ToString(), out g) && byte.TryParse(rgb[2].ToString(), out b))
			{
				Red = r;
				Green = g;
				Blue = b;
			}
			else
			{
				Red = (byte)(rgb[0] * 255);
				Green = (byte)(rgb[1] * 255);
				Blue = (byte)(rgb[2] * 255);
			}
		}

		public Colour(List<float> rgb, byte multiplier) : this((byte)(multiplier * rgb[0]), (byte)(multiplier * rgb[1]), (byte)(multiplier * rgb[2]))
		{

		}

	}
}
