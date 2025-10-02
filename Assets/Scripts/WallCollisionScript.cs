using UnityEngine;

public class WallCollisionScript : MonoBehaviour
{
    [SerializeField]
    Material NormalWallMaterial;

    [SerializeField]
    Material TouchedWallMaterial; 

    private void OnCollisionEnter(Collision colliding)
    {
        Debug.Log(colliding.gameObject.name);

        if (colliding.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = TouchedWallMaterial;
        }
    }

}
