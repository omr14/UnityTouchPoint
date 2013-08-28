using UnityEngine;
using System.Collections;

public class TPPointer : MonoBehaviour
{
	private readonly Vector3 _force = new Vector3( 0.0f, 0.0f, 10.0f );
	private float _depthFromCamera = 5.0f;
	
	TouchPointInteface _tp = null;
	
	
	void Start ()
	{
		_tp = TouchPointCreator.Create();
	}
	
	void Update ()
	{
		if ( _tp.Count() > 0 )
		{
			Vector2 point = _tp.Point();
			
			transform.position = Camera.main.ScreenToWorldPoint( new Vector3( point.x, point.y, _depthFromCamera ) );
		}
	}
	
	void OnTriggerEnter( Collider other )
	{
		Debug.Log("TriggerEnter");
		
		if ( other.rigidbody != null && _tp.Count() != 0 )
		{
			other.rigidbody.AddForce( _force, ForceMode.Impulse );
		}
	}
	
	
	void OnGUI()
	{
		GUILayout.TextArea( transform.position.ToString() );
		
	}
}
