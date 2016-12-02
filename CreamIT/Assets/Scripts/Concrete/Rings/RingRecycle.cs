﻿using UnityEngine;
using System;

public class RingRecycle : MonoBehaviour {

	public static Action<NavAgent> SendToGenerator;
	public NavAgent navAgent;
	public SpriteRenderer center;
	public Material black;

	void Start()
	{
		SendToGenerator(navAgent);
		ResetGame.ResetLevel += ResetRing;
	}
	
	void OnTriggerEnter()
	{
		ResetRing();
		SendToGenerator(navAgent);
	}

    private void ResetRing()
    {
        center.material = black;
		navAgent.StopAgent();
    }
}
