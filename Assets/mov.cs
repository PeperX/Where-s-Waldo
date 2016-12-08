using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {

	int posX = 0;
	int posY = 0;
	[SerializeField] AudioSource tecladinho;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.Quit();
		}

		if (Input.GetKey(KeyCode.RightArrow)&&!Input.GetKey(KeyCode.UpArrow)&& !Input.GetKey(KeyCode.DownArrow)) 
		{
			transform.position += new Vector3(5f*Time.deltaTime,0,0);
			posX+=1;
			Debug.Log(posX.ToString());
		}

		if (Input.GetKey (KeyCode.LeftArrow)&&!(Input.GetKey(KeyCode.UpArrow)&& !Input.GetKey(KeyCode.DownArrow)))
		{
			transform.position += new Vector3(-5f*Time.deltaTime,0,0);
			posX-=1;
			Debug.Log(posX.ToString());
		}
		if (Input.GetKey (KeyCode.UpArrow)&&!(Input.GetKey(KeyCode.LeftArrow)&& !Input.GetKey(KeyCode.RightArrow)))
		{
			transform.position += new Vector3(0,5f*Time.deltaTime,0);
			posY-=1;
			Debug.Log(posY.ToString());
		}
		if (Input.GetKey (KeyCode.DownArrow)&!(Input.GetKey(KeyCode.LeftArrow)&& !Input.GetKey(KeyCode.RightArrow)))
		{
			transform.position += new Vector3(0,-5*Time.deltaTime,0);
			posY-=1;
			Debug.Log(posY.ToString());
		}

	}

	void OnTriggerStay2D(Collider2D outro){
		if(outro.tag == "alvo" && Input.GetKey(KeyCode.Space)/*&& AudioClip.Instantiate("tecladinho")*/){
			//Application.LoadLevel ("end");
			tecladinho.Play();
			Invoke("ChamarFim", 3);
			}
		 }

	void ChamarFim(){
		Application.LoadLevel("end");
	}

}
