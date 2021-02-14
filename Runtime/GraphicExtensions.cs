using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class GraphicExtensions
{
	public static void setAlpha (this Graphic graphic, int alpha)
	{
		Color color = graphic.color;
		color.a = alpha;
		graphic.color = color;
	}
}
