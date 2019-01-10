using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueBar : MonoBehaviour {

    public float percentage = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Find("BarContent").transform.localScale = new Vector2(percentage, 1.0f);
        transform.Find("BarContent").GetComponent<Image>().color = new Color(1.0f, percentage, percentage);
	}
}
