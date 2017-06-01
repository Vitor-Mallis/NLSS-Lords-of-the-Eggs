using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class TimeManager {

	static public IEnumerator WaitForRealSeconds(float time) {
		float elapsedTime = Time.realtimeSinceStartup;

		while (Time.realtimeSinceStartup < elapsedTime + time) {
			yield return null;
		}
	}
}
