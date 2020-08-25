using System.Collections;
using System.Collections.Generic;
using Malimbe.PropertySerializationAttribute;
using UnityEngine;
using UnityEngine.Events;
using Zinnia.Action;

public class ReorderableUnityEventsTest : MonoBehaviour
{
    public UnityEvent testEvent = new UnityEvent();
    
    public FloatAction.UnityEvent floatEvent = new FloatAction.UnityEvent();
    
    public Vector3Action.UnityEvent vector3Event = new Vector3Action.UnityEvent();
    
    [Serialized]
    public UnityEvent malimbeSerializedEvent { get; set; } = new UnityEvent();

    public void DummyMethod() => Debug.Log("DummyMethod called.");
    
    public void DummyFloatMethod(float value) => Debug.Log($"DummyFloatMethod called (value = {value}).");
    
    public void DummyVector3Method(Vector3 value) => Debug.Log($"DummyVector3Method called (value = {value}).");
}
