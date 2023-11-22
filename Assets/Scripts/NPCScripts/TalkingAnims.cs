using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingAnims : MonoBehaviour
{
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void StartTalkingAnim()
    {
        _anim.SetBool("IsTalking", true);
    }

    public void StopTalkingAnim()
    {
        _anim.SetBool("IsTalking", false);
    }

}
