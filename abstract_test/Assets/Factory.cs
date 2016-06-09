using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Factory : UIBehaviour
{
	[SerializeField]
	private Canvas _canvas;
	[SerializeField]
	private ConcreteMarker1 _prefab1;
	[SerializeField]
	private ConcreteMarker2 _prefab2;
	
	[SerializeField]
	private Button _init1;
	[SerializeField]
	private Button _init2;

	public void Init1()
	{
		AbstractMarker marker = Instantiate<ConcreteMarker1>(_prefab1);
		marker.transform.position = Vector3.one * 100;
		marker.transform.SetParent(_canvas.transform);

		marker.Init("marker1");
	}

	public void Init2()
	{
		AbstractMarker marker = Instantiate<ConcreteMarker2>(_prefab2);
		marker.transform.position = Vector3.one * 200;
		marker.transform.SetParent(_canvas.transform);

		marker.Init("marker2");
	}
}

