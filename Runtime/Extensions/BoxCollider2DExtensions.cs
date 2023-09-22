using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RicardoRalha.Core.Extensions
{
	public static class BoxCollider2DExtensions
	{
		public static void setSizeX(this BoxCollider2D c, float x)
		{
			Vector2 size = c.size;
			size.x = x;
			c.size = size;
		}

		public static void setSizeY(this BoxCollider2D c, float y)
		{
			Vector2 size = c.size;
			size.y = y;
			c.size = size;
		}

		public static void setSizeXY(this BoxCollider2D c, float x, float y)
		{
			Vector2 size = c.size;
			size.x = x;
			size.y = y;
			c.size = size;
		}
	}
}
