using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class RenderScale : MonoBehaviour {

	[SerializeField] private float m_RenderScale = 1f;              //The render scale. Higher numbers = better quality, but trades performance

	// Use this for initialization
	void Start () {
		VRSettings.renderScale = m_RenderScale;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
