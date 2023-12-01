using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ярик пидарас");
    }
}
