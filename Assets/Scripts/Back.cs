using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	public float scrollSpeed1 = 0.05f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.deltaTime * scrollSpeed1;
		renderer.material.mainTextureOffset = new Vector2 (renderer.material.mainTextureOffset.x - offset, 0.0f);	
	}
}
