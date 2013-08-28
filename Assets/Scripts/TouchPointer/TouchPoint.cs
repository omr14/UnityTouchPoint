using UnityEngine;
using System.Collections;

public class TouchPoint : TouchPointInteface
{
	public int Count()
	{
		return Input.touches.Length;
	}
	
	public Vector2 Point()
	{
		if ( Input.touches.Length > 0 )
		{
			return Input.touches[0].position;
		}
		else
		{
			return Vector2.zero;
		}
	}
}

public class TouchPointMouse : TouchPointInteface
{
	public int Count()
	{
		if ( Input.GetMouseButton(0) )
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}
	
	
	public Vector2 Point()
	{
		if ( Input.GetMouseButton(0) )
		{
			Vector3 mousepos = Input.mousePosition;
			return new Vector2( mousepos.x, mousepos.y);
		}
		else
		{
			return Vector2.zero;
		}
		
	}
	
}
