using UnityEngine;
using TMPro;

public class WinningDetector : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaDeVictoria;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float gameTime = 0f;
    bool isPlaying = true;

    private void Update()
    {
        if (isPlaying == true)
        {
            gameTime = gameTime + Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Se llegó a la meta");
            pantallaDeVictoria.SetActive(true);
            other.GetComponent<MovimientoJugador>().enabled = false;
            isPlaying = false;
            Debug.Log(gameTime);
            textLabelTime.text = gameTime.ToString();
        }
    }


}
