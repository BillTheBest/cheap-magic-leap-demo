using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Whale : MonoBehaviour {

	Animation anim;
	List<string> animNames = new List<string>();

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
		foreach (AnimationState state in anim)
		{
			animNames.Add(state.name);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!anim.isPlaying) {
			var nextAnimName = animNames[Random.Range(0, animNames.Count - 1)];
			Debug.LogFormat("play: {0}", nextAnimName);
			anim.Play(nextAnimName);
			anim.wrapMode = WrapMode.Once;
		}
	}
}
