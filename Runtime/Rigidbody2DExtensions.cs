using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RicardoRalha.Core.Extensions
{
	public static class Rigidbody2DExtensions
	{
		public static void setVelocityX(this Rigidbody2D rb, float x)
		{
			Vector2 velocity = rb.velocity;
			velocity.x = x;
			rb.velocity = velocity;
		}

		public static void setVelocityY(this Rigidbody2D rb, float y)
		{
			Vector2 velocity = rb.velocity;
			velocity.y = y;
			rb.velocity = velocity;
		}

		public static void setVelocityXY(this Rigidbody2D rb, float x, float y)
		{
			Vector2 velocity = rb.velocity;
			velocity.x = x;
			velocity.y = y;
			rb.velocity = velocity;
		}

		public static void setPositionX(this Rigidbody2D rb, float x)
		{
			Vector2 position = rb.position;
			position.x = x;
			rb.position = position;
		}

		public static void setPositionY(this Rigidbody2D rb, float y)
		{
			Vector2 position = rb.position;
			position.y = y;
			rb.position = position;
		}

		public static void setPositionXY(this Rigidbody2D rb, float x, float y)
		{
			Vector2 position = rb.position;
			position.x = x;
			position.y = y;
			rb.position = position;
		}
	}
}
