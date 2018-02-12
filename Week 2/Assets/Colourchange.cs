using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colourchange : MonoBehaviour {

	// Use this for initialization

	public MeshRenderer meshRenderer;
	public Color colour;

	void Start () {
		meshRenderer.GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up"))
			meshRenderer.material.color = colour;
	}
}
