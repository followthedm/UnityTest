using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 velocity = transform.position;
		velocity.x = -200.0f;
		velocity.y = 0.0f;
		rigidbody.AddForce(velocity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "Player") {
			//score = GameObject.Find("ScoreBoard");
			//score.SendMessage("ApplyPoint",point);
			Destroy(gameObject);
		}else if (other.gameObject.tag == "EndPoint"){
			Destroy(gameObject);
		}
	}
}
