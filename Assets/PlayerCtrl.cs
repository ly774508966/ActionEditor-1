using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using static SimpleAnimationPlayable;

public class PlayerCtrl : MonoBehaviour
{
    public StateInfoScriptableObject stateInfoScriptable;

    public SimpleAnimation simpleAnimation;
    public float gameSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        simpleAnimation.AddState(stateInfoScriptable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Button("Set Game Speed")]
    public void SetGameSpeed()
    {
        Time.timeScale = gameSpeed;
    }

    [Button("Play Idle")]
    public void PlayIdle()
    {
        simpleAnimation.Play("Default");
    }

    [Button("Play Walk")]
    public void PlayWalk()
    {
        simpleAnimation.Play("Walk");
    }

    [Button("Play Run")]
    public void PlayRun()
    {
        simpleAnimation.Play("Run");
    }

    [Button("Play Attack")]
    public void PlayAttack()
    {
        simpleAnimation.Play("Attack");
    }

    [Button("Play Dash")]
    public void PlayDash()
    {
        simpleAnimation.Play("Dash");
    }

    [Button("Play RunFast")]
    public void PlayRunFast()
    {
        simpleAnimation.Play("RunFast");
    }


    public float time = 0.2f;
    [Button("CrossFade Attack")]
    public void CrossFadeAttack()
    {
        simpleAnimation.CrossFade("Attack", time);
    }
}
