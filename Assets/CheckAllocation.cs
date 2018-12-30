﻿using System.Collections.Generic;
using Svelto.Tasks;
using Svelto.Tasks.Enumerators;
using Svelto.Tasks.Unity;
using UnityEngine;

public class CheckAllocation : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		UpdateIT().Start();
	}

	IEnumerator<TaskContract?> UpdateIT()
	{
		var waitForSecondsEnumerator = new WaitForSecondsEnumerator(0.1f);
		var syncRunner = new SyncRunner();
		while (true)
		{
//			yield return waitForSecondsEnumerator.Run(syncRunner);
			
			yield return null;
		}
	}
}