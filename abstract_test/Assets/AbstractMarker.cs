using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class AbstractMarker : UIBehaviour 
{
	public string Text	{ set { GetComponentInChildren<Text>().text = value; }}

	public virtual void Init(string text)
	{
		Text = text;
	}

	protected override void Awake()
	{
		base.Awake();

		ChangeColor();
	}

	private void ChangeColor()
	{
		GetComponent<Button>().image.color = Color.green;
	}
}
