using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneHit : MonoBehaviour {
    [SerializeField]
    private GameObject _Cube;
    private GameObject _RuneColor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _RuneColor = gameObject;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _RuneColor.GetComponent<RandomCollour>().GetColor().ToString())
        {
            Explode(other.gameObject);
            CubeDingen(other.gameObject);
            Destroy(other.gameObject);
            Debug.Log("Geraakt");
        }
        else
        {
            _Cube.GetComponent<rotate>().ModDown();
        }
    }

    private void Explode(GameObject Particle)
    {

    }

    private void CubeDingen(GameObject ParticleEnter)
    {
        ParticleSystem.MainModule particle = _Cube.transform.GetChild(0).GetComponent<ParticleSystem>().main;
        particle.startColor = ParticleEnter.GetComponent<ParticleSystem>().main.startColor;
        _Cube.GetComponent<rotate>().ModUp();
    }
}
