using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class ActionBehaviour : MonoBehaviour
{

    public abstract Action GetClickAction();

    public Sprite ButtonPic;
    
}
