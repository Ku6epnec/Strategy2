using System;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(Vector3Value), menuName = "Strategy Game/" + nameof(Vector3Value), order = 0)]
public class Vector3Value : ScriptableObjectValueBase<IVector3Value>
{
	public new Vector3 CurrentValue { get; private set; }
	public new Action<Vector3> OnNewValue;

	public void SetValue(Vector3 value)
	{
		CurrentValue = value;
		OnNewValue?.Invoke(value);
	}
}