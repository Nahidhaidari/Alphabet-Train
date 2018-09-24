using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moving : MonoBehaviour {
	public Transform pos1,pos2,startPos;
	public float speed;
	public GameObject train;
	public GameObject a;
	public GameObject b;
	public GameObject c;
	public GameObject d;
	public GameObject e;
	public GameObject f;
	public GameObject g;
	public int delay;


	Vector3 nextPos;

	// Use this for initialization
	void Start () {
		nextPos = startPos.position;
	}

	// Update is called once per frame
	void Update () {
		if(transform.position==pos1.position){
			nextPos = pos2.position;
		}
		if(transform.position==pos2.position){
			train.gameObject.GetComponent<Animator> ().enabled = false;
			StartCoroutine (ActiveAnimation(delay));

		}
		transform.position = Vector3.MoveTowards (transform.position,nextPos,speed*Time.deltaTime);

	}
	IEnumerator ActiveAnimation(int delay){
		a.gameObject.GetComponent<Animator> ().enabled =true;
		yield return new WaitForSeconds(delay);
		b.gameObject.GetComponent<Animator> ().enabled =true;
		yield return new WaitForSeconds(delay);
		c.gameObject.GetComponent<Animator> ().enabled =true;
		yield return new WaitForSeconds(delay);
		d.gameObject.GetComponent<Animator> ().enabled =true;
		yield return new WaitForSeconds(delay);
		e.gameObject.GetComponent<Animator> ().enabled =true;
		yield return new WaitForSeconds(delay);
		f.gameObject.GetComponent<Animator> ().enabled =true;
		yield return new WaitForSeconds(delay);
		g.gameObject.GetComponent<Animator> ().enabled =true;
		yield return new WaitForSeconds(delay);


	}
}