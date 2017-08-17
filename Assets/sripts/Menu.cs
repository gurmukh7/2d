
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Menu : MonoBehaviour
{

    public Canvas MainCanvas;
    public Canvas OptionsCanvas;

    void Awake()
    {
        OptionsCanvas.enabled = false;

    }
    public void OptionsOn()
    {
        OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;

    }
    public void GobackOn()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = true;
    }
    public void LoadOn()
    {
        Application.LoadLevel(1);

    }
}
