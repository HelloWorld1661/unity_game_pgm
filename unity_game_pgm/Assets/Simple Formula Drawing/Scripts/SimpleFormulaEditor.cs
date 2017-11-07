using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SimpleFormula))]
public class BardBuildingEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		SimpleFormula myScript = (SimpleFormula)target;
		if(GUILayout.Button("Create Equation"))
		{

			myScript.CreateEquation();
		}

		if(GUILayout.Button("Delete Equation"))
		{
			GameObject[] foundGO = GameObject.FindGameObjectsWithTag ("formula");

			for (int ii = 0; ii < foundGO.Length; ii++) {
				DestroyImmediate (foundGO [ii]);
			}


		}


	}
}

