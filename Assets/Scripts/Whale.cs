using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Whale : MonoBehaviour {

	Animation anim;
	AnimationState currentState = null;
	List<string> animNames = new List<string>();
	
	float kFadeInSeconds = 0.5f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
		foreach (AnimationState state in anim)
		{
			animNames.Add(state.name);
		}
		
		FadeIn();
	}
	
	void FadeIn() {
		var nextAnimName = animNames[Random.Range(0, animNames.Count - 1)];
		Debug.LogFormat("play: {0}", nextAnimName);
		anim.CrossFade(nextAnimName, kFadeInSeconds);
		anim.wrapMode = WrapMode.Once;
		currentState = anim[nextAnimName];
	}
	
	// Update is called once per frame
	void Update () {
		if (currentState.time > currentState.length - kFadeInSeconds) {
			FadeIn();
		}
	}
}
