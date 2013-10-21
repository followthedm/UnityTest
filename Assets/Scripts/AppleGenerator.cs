using UnityEngine;
using System.Collections;

public class AppleGenerator : MonoBehaviour {

	private float interval; // Apple発生周期
	public GameObject applePrefab;
	private float timer;

	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0.0f) {
			//Vector3 position = new Vector3(18.0f, 2.75f, 0.0f);
			Instantiate(applePrefab, transform.position, transform.rotation);
			interval = Random.Range(2.0f, 4.0f);
			timer = interval;
		}
	}
}
