using UnityEngine;

public class WinningDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Se llegó a la meta");
        }
    }


}
