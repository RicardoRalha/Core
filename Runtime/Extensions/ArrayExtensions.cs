using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RicardoRalha.Core.Extensions
{
	public static class ArrayExtensions
	{
		public static List<T> ToList<T>(this T[] array)
		{
			List<T> list = new List<T>();
			for (int i = 0; i < array.Length; i++) {
				list.Add(array[i]);
			}
			return list;
		}

	}
}

