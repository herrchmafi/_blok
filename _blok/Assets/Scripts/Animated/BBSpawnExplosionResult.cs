﻿using UnityEngine;
using System.Collections;

public class BBSpawnExplosionResult : MonoBehaviour, BBExplosionResult {
	public Transform spawnTransform;
	private BBSpriteFactory factory;
	// Use this for initialization
	void Start () {
		this.factory = GameObject.FindGameObjectWithTag(BBSceneConstants.gameControllerTag).GetComponent<BBSpriteFactory>(); 	
	}
	
	public void ExplosionResult() {
		Transform spawn = Instantiate(this.spawnTransform, transform.position, Quaternion.identity) as Transform;
		BBEventController.SendSpawnNotification(spawn.tag);
		Destroy(gameObject);
	}	
}
