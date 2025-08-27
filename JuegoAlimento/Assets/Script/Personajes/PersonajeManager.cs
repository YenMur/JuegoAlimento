using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PersonajeManager : MonoBehaviour
{
    public BaseDatosPersonajes bdPersonajes;

    public Image personajeImagen;

    private int opcionSeleccionada = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if(!PlayerPrefs.HasKey("PersonajeSeleccionado"))
        {
            opcionSeleccionada = 0;
        }
        else
        {
                       Load();
        }

            UpdateCharacter(opcionSeleccionada);
    }
    
    public void SiguienteOpcion()
    {
        opcionSeleccionada++;

        if (opcionSeleccionada >= bdPersonajes.PersonajesCount)
        {
            opcionSeleccionada = 0;
        }
        UpdateCharacter(opcionSeleccionada);
        Save();
    }

    public void OpcionAnterior()
    {
        opcionSeleccionada--;
        if (opcionSeleccionada < 0)
        {
            opcionSeleccionada = bdPersonajes.PersonajesCount - 1;
        }
        UpdateCharacter(opcionSeleccionada);
        Save();
    }

    private void UpdateCharacter(int opcionSeleccionada)
    {
        Personajes personaje = bdPersonajes.GetPersonaje(opcionSeleccionada);
        personajeImagen.sprite = personaje.personajeSprite;
    }

    private void Load()
    {
        opcionSeleccionada = PlayerPrefs.GetInt("PersonajeSeleccionado");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("PersonajeSeleccionado", opcionSeleccionada);
    }

    public void CambiarEscena(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

}
