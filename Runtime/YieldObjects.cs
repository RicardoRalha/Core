using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YieldObjects
{
	private static WaitForEndOfFrame endOfFrameObject = null;
	private static Dictionary<float, WaitForSeconds> waitForSecondsObjectsDict = new Dictionary<float, WaitForSeconds>();
	public static WaitForEndOfFrame GetWaitForEndOfFrame()
	{
		if (endOfFrameObject == null) {
			endOfFrameObject = new WaitForEndOfFrame();
		}

		return endOfFrameObject;
	}

	public static WaitForSeconds WaitForSeconds(float time)
	{
		WaitForSeconds waitForSecondsObj = null;
		if (!waitForSecondsObjectsDict.TryGetValue(time, out waitForSecondsObj)) {
			waitForSecondsObj = new WaitForSeconds(time);
			waitForSecondsObjectsDict.Add(time, waitForSecondsObj);
		}

		return waitForSecondsObj;
	}
}
