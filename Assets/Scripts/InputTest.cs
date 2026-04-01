using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    public InputActionProperty GripAction;
    public InputActionProperty GripActionValue;
    public InputActionProperty TriggerAction;
    public InputActionProperty TriggerActionValue;
    public bool GrirButton;
    public float GripValue;
    public bool TriggerButton;
    public float TriggerValue;

    void Update()
    {
        GrirButton = GripAction.action.IsPressed();
        GripValue = GripActionValue.action.ReadValue<float>();
        GrirButton = TriggerAction.action.IsPressed();
        GripValue = TriggerActionValue.action.ReadValue<float>();
    }
}
