using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    [SerializeField]
    private Vector3 _Rotatie;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        gameObject.transform.Rotate(_Rotatie * Time.fixedDeltaTime);

        
    }
}
