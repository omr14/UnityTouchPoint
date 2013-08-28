using UnityEngine;
using System.Collections;

public class TPSphereCreator : MonoBehaviour
{
	public GameObject _sphere;
	public float _sphereOffset = 0.1f;
	
	private readonly float _xRange = 5.0f;
	private readonly float _yRange = 4.0f;
	
	// Use this for initialization
	void Start ()
	{
		Vector3 sphereScale = new Vector3( _sphereOffset, _sphereOffset, _sphereOffset );
		
		for ( float i = -_xRange; i <= _xRange; i += _sphereOffset )
		{
			for ( float j = -_yRange; j <= _yRange; j += _sphereOffset)
			{
				CreateSphere( new Vector3( i, j, 0.0f ), sphereScale, transform );
			}
			
		}
	}
	
	GameObject CreateSphere(Vector3 pos, Vector3 scale, Transform parent)
	{		
		GameObject sphere = Instantiate( _sphere ) as GameObject;
		
		sphere.transform.parent = parent;	
		sphere.transform.position = pos;
		sphere.transform.localScale = scale;
		
		return sphere;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
}
