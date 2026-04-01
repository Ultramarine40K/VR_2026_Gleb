using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimaton : MonoBehaviour
{
    public InputActionProperty GripValue;
    public InputActionProperty TriggerValue;
    public Animator HandAnimator;
    void Update()
    {
        float grip = GripValue.action.ReadValue<float>();
        float trigger = TriggerValue.action.ReadValue<float>();

        HandAnimator.SetFloat("Grip", grip);
        HandAnimator.SetFloat("Trigger", trigger);

    }
}
