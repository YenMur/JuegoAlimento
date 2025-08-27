using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController1 : MonoBehaviour
{

    [SerializeField] private TMP_InputField ITNombre;
    [SerializeField] private TMP_InputField ITEdad;
    [SerializeField] private TMP_InputField ITCiudad;
    [SerializeField] private TMP_InputField ITCorreo;

    public string nombre;
    public int edad;
    public string ciudad;
    public string correo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetUserdata()
    {
        try
        {
            nombre = ITNombre.text;
            edad = int.Parse(ITEdad.text);
            ciudad = ITCiudad.text;
            correo = ITCorreo.text;

            Debug.Log(nombre);   
            Debug.Log(edad);
            Debug.Log(ciudad);
            Debug.Log(correo);
        }
        catch (System.Exception)
        {
            Debug.Log("Error al obtener los datos del usuario");
        }
    }
}