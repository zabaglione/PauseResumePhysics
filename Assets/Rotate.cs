using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector3 angle;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(angle * speed * Time.deltaTime);
	}
}
