using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [Space]
    [TextArea(3, 15)]

    [Space]
    public string _name;
    public string[] _sentences;
}
