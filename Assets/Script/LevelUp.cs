using UnityEngine;

public class LevelUp : MonoBehaviour
{
    [SerializeField] private GameObject teleportInteractionObject;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Activate()
    {
        if (teleportInteractionObject != null)
        {
            teleportInteractionObject.SetActive(true);
        }
    }

    public void Disactivate()
    {
        if (teleportInteractionObject != null)
        {
            teleportInteractionObject.SetActive(false);
        }
    }
}
