using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		WordBank wordbank = WordBank.Instance;
		Debug.Log("wordbank contains Wonderful - " + wordbank.IsContaining("Wonderful"));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
