using UnityEngine;
using System.Collections;

public class ConcreteMarker1 : AbstractMarker
{
	public override void Init (string text)
	{
		base.Init (text);

		Debug.Log("ConcreteMarker1 >> Init");
	}
}

