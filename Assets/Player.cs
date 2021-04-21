using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public float Kecepatan = 50f;
    public Rigidbody rb;
    private int point;
    public Text pointText;


    // Use this for initialization
    void Start () {
		// rb = GetComponent<Rigidbody>();
        point = 0;
        SetCounText();
        // Debug.Log(point);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("space")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * Kecepatan);
        }
		if(Input.GetKey("x")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * -Kecepatan);
        }
		if(Input.GetKey("up")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * Kecepatan);
        }
		if(Input.GetKey("down")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * -Kecepatan);
        }
		if(Input.GetKey("right")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * -Kecepatan);
        }
		if(Input.GetKey("left")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * Kecepatan);
        }
		if(Input.GetKey("w")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * Kecepatan);
        }
		if(Input.GetKey("s")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * -Kecepatan);
        }
		if(Input.GetKey("d")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * -Kecepatan);
        }
		if(Input.GetKey("a")){
            transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * Kecepatan);
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Musuh"))
        {
            other.gameObject.SetActive(false);
            point = point + 1;
            SetCounText();
        }
    }

    void SetCounText()
    {
        pointText.text = "Point : "+ point.ToString();
        // Debug.Log(point);
    }
}