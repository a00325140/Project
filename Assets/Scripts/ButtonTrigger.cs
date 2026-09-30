using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonTrigger : MonoBehaviour
{
    private Animator _buttonAnimator;
    void Start()

    {
        _buttonAnimator = GetComponent<Animator>();

    }
    private void onTriggerEnter(Collider other) 
    {
        _buttonAnimator.SetTrigger("ButtonPressed");
    }

    
}
