using UnityEngine;

public interface TouchPointInteface
{
	int Count();
	Vector2 Point();
}


public class TouchPointCreator
{
	public static TouchPointInteface Create()
	{
		if ( Application.platform == RuntimePlatform.Android 
			|| Application.platform == RuntimePlatform.IPhonePlayer )
		{
			return new TouchPoint();
		}
		else if ( Application.platform == RuntimePlatform.WindowsEditor
			|| Application.platform == RuntimePlatform.WindowsPlayer )
		{
			return new TouchPointMouse();
		}
		
		return null;
	}
}