using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    [SerializeField]
    private Vector3 _Rotatie;
    private float _Mod;
    
	// Use this for initialization
	void Start () {
        _Mod = 1.2f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        gameObject.transform.Rotate(_Rotatie * Time.fixedDeltaTime);

        
    }

    public void ModUp()
    {
        _Rotatie *= _Mod;
        _Mod *= _Mod;
    }
    public void ModDown()
    {
        _Mod = Mathf.Sqrt(_Mod);
        _Rotatie /= _Mod;
    }
}
