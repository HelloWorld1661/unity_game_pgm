using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class CoinText : MonoBehaviour {

//	void Start()
//	{
//		var parent = transform.parent;
//
//		var parentRenderer = parent.GetComponent<Renderer>();
//		var renderer = GetComponent<Renderer>();
//		renderer.sortingLayerID = parentRenderer.sortingLayerID;
//		renderer.sortingOrder = parentRenderer.sortingOrder;
//
//		var spriteTransform = parent.transform;
//		var text = GetComponent<TextMesh>();
//		var pos = spriteTransform.position;
//		text.text = string.Format("{0}, {1}", pos.x, pos.y);
//	}
//
//	void Start () 
//	{
////		this.renderer.sortingLayerID = this.transform.parent.renderer.sortingLayerID;
//		this.GetComponent<Renderer> (SortingLayerID) = this.GetComponentInParent<Renderer> (SortingLayerID);
//	}
//}



public class CoinText : MonoBehaviour {
	
	public int SortLayer = -1;
	public int SortingLayerID;

	// Use this for initialization
	void Start () {
		SortingLayerID = SortingLayer.GetLayerValueFromName("Default");
		Renderer renderer = this.gameObject.GetComponent<Renderer>();
		if(renderer != null)
		{
			renderer.sortingOrder = SortLayer;
			renderer.sortingLayerID = SortingLayerID;
		}
	}

}