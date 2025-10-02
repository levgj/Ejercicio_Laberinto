using Unity.VisualScripting;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    public float velocidadMovimiento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Debug.Log("Hola mundo"); 

    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;

        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
