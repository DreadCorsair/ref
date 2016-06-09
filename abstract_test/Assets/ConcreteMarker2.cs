using UnityEngine;
using System.Collections;

public class ConcreteMarker2 : AbstractMarker
{
	public override void Init (string text)
	{
		base.Init (text);

		Debug.Log("ConcreteMarker2 >> Init");
	}
}

