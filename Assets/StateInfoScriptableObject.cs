using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/StateInfo",fileName ="New StateInfo",order = 0)]
public class StateInfoScriptableObject : ScriptableObject
{
    public string stateName;
    public AnimationClip clip;
    public WrapMode wrapMode;

    public AnimationClipEvent[] animationEvents;

}

[Serializable]
public class AnimationClipEvent
{
    public int frameIndex = 0;
    public Enum_AnimationClipEvent type;
}

public enum Enum_AnimationClipEvent
{
    None = 0,
    AnimationEnd = 1,
}
