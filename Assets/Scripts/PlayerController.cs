using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpSpeed = 7.5f;
	public float gravity = 6.0f;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = (CharacterController)GetComponent("CharacterController");
	}
	
	// Update is called once per frame
	void Update () {
	//地面についているかどうか
		if (controller.isGrounded) {
			
			//ジャンプ
			if (Input.GetButton ("Jump")) {
				moveDirection.y = jumpSpeed;
			}
		}
		
		// 重力を計算
		moveDirection.y -= gravity * Time.deltaTime;
		
		// 移動
		controller.Move(moveDirection * Time.deltaTime);
	}
}
