using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalButton : MonoBehaviour {
	public Text label;

	public RectTransform rectTransform {
		get {
			if (_rectTransform == null)
				_rectTransform = GetComponent<RectTransform> ();
			return _rectTransform;
		}
	}
	RectTransform _rectTransform;

	public AppManager calManager {
		get {
			if (_calManager == null)
				_calManager = GetComponentInParent<AppManager> ();
			return _calManager;
		}
	}
	static AppManager _calManager;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void onTapped()
	{
		Debug.Log ("Tapped: " + label.text);
		calManager.buttonTapped (label.text [0]);
	}
}

