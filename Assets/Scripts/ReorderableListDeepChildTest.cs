using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReorderableListDeepChildTest : ReorderableListChildTest
{
    public List<string> deepChildList = new List<string>(){"one", "two", "three"};
    
    public UnityEvent deepChildEventList = new UnityEvent();
}
