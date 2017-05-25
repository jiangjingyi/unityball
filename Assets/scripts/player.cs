using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	public Animator anim;
	private float inputH;
	private float inputV;
	private bool run;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1")){
			anim.Play ("WAIT01", -1, 0f);
		}else if(Input.GetKeyDown("2")){
			anim.Play ("WAIT02", -1, 0f);
		}else if(Input.GetKeyDown("3")){
			anim.Play ("WAIT03", -1, 0f);
		}else if(Input.GetKeyDown("4")){
			anim.Play ("WAIT04", -1, 0f);
		}
		inputH = Input.GetAxis("Horizontal");//左右キー
		inputV = Input.GetAxis ("Vertical");//上下キー
		anim.SetFloat ("inputH", inputH);
		anim.SetFloat("inputV",inputV);

		if (Input.GetKey (KeyCode.LeftShift)) {
			run = true;
		} else {
			run = false;
		}
		anim.SetBool ("run", run);

	}
}
