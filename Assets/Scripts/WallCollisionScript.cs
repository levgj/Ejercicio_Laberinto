using UnityEngine;

public class WallCollisionScript : MonoBehaviour
{
    [SerializeField]
    Material NormalWallMaterial;

    [SerializeField]
    Material TouchedWallMaterial;

    bool paredOscura = false;

    float tiempoparedOscura = 5f;

    private void Update()
    {
        if (paredOscura == true)
        {
            tiempoparedOscura = tiempoparedOscura - Time.deltaTime;
            if (tiempoparedOscura < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = NormalWallMaterial;
                paredOscura = false;
                tiempoparedOscura = 5f;

            }
        }
    }

    private void OnCollisionEnter(Collision colliding)
    {
        Debug.Log(colliding.gameObject.name);

        if (colliding.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = TouchedWallMaterial;
            paredOscura = true;
        }
    }

}
