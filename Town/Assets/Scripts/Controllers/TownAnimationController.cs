using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownAnimationController : TownAnimations
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        _controller.OnMoveEvent += Move; 
    }

    private void Move(Vector2 obj)
    {
        _animator.SetBool(IsWalking, obj.magnitude > .5f);
    }
}
