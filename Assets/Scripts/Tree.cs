using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {

	public float scrollSpeed2 = 0.05f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.deltaTime * scrollSpeed2;
		renderer.material.mainTextureOffset = new Vector2 (renderer.material.mainTextureOffset.x - offset, 0.0f);	
	}
}
