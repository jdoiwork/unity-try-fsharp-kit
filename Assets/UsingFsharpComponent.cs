using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UsingFsharpComponent : MonoBehaviour {

  public FSharp.HelloFsharp hello;
  public TMP_Text uiText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    uiText.text = hello.mytext;
	}
}
