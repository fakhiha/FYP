using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateRightHandOnInput : MonoBehaviour
{
   

    // Start is called before the first frame update
    public InputActionProperty pinchAnimationAction;
    public Animator handAnimator;
    public InputActionProperty gripAnimationAction;
    void Start()
    {

    }

    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }




}
