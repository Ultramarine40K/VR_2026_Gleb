using UnityEngine;

public class BascetRing : MonoBehaviour
{
    public GameObject FX;

    private void OnTriggerExit(Collider other)
    {
        Instantiate(FX, transform.parent);
    }
}
