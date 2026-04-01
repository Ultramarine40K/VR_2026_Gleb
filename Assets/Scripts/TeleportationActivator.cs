using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationActivator : MonoBehaviour
{
    public InputActionProperty TeleportActivatorAction;
    public XRRayInteractor TeleportInteractor;

    void Start()
    {
        TeleportInteractor.gameObject.SetActive(false);
        TeleportActivatorAction.action.performed += ActionPerformed;
    }

    void ActionPerformed(InputAction.CallbackContext obj)
    {
        TeleportInteractor.gameObject.SetActive(true);

    }

    void Update()
    {
        if (TeleportActivatorAction.action.WasPressedThisFrame())
        {
            TeleportInteractor.gameObject.SetActive(false);
        }
    }
}
