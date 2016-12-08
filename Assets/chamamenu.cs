using UnityEngine;
using System.Collections;

public class chamamenu : MonoBehaviour {
	float relogio;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		relogio += Time.deltaTime;

		if(relogio>2)
			Application.LoadLevel ("menu");

		
		
	}
}
