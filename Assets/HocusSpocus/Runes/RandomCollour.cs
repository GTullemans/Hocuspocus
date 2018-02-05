using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollour : MonoBehaviour {
    [SerializeField]
    private GameObject _Runes;
    private GameObject[] _RuneArray;
    [SerializeField]
    private List<Color> _Color;
    [SerializeField]
    private float _TimeNominal;
    private float _Timer;
    private Color _GetColor;
	// Use this for initialization
	void Start () {
        _RuneArray = new GameObject[_Runes.transform.childCount];
		for(int i = 0; i < _Runes.transform.childCount; i++)
        {
            _RuneArray[i] = _Runes.transform.GetChild(i).gameObject;
        }
	}
	
	// Update is called once per frame
	void Update () {
        _Timer += Time.deltaTime;
        if(_Timer > Random.Range(_TimeNominal - 5, _TimeNominal + 5))
        {
            _GetColor = _Color[Random.Range(0, _Color.Count)];
            GameObject ChosenOne = _RuneArray[Random.Range(0, _RuneArray.Length - 1)];
            ChosenOne.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = _GetColor;
            _Timer = 0;
        }
	}


    public Color GetColor()
    {
        return _GetColor;
    }
}
