using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownAnimations : MonoBehaviour
{
    protected Animator _animator;
    protected TownCharacterController _controller;

    protected virtual void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _controller = GetComponent<TownCharacterController>();
    }
}
