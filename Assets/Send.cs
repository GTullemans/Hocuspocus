using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Send : MonoBehaviour {
    [SerializeField]
    private float _FollowSpeed;
    private Vector3 _FollowDir;
    private Rigidbody _RigidBody;
	// Use this for initialization
	void Start () {
        _RigidBody = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
                _FollowDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gameObject.transform.position;
                //_FollowSpeed = _FollowDir.x + _FollowDir.z;
                _FollowDir = new Vector3(_FollowDir.x, 0, _FollowDir.z);
                _FollowDir = _FollowDir.normalized;

                _RigidBody.AddForce(_FollowDir * _FollowSpeed, ForceMode.Force);
           
           
        }
	}


}
