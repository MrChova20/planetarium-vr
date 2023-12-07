using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems; // Required for pointer events
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class interactionIntruccionesCerrar : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler // Implement the necessary interfaces
{
    public UnityEvent myEventClick;
    public Button button;
    Color currentColor;
    public Sprite imageHover;
    public Sprite imageDefault;
    public Canvas canvas;
    int cont = 0;

    void Start()
    {
        if (button == null)
        {
            button = GetComponent<Button>(); // Automatically get the button component if not set
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (imageHover != null)
        {
            button.image.sprite = imageHover; // Change the sprite on hover
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (imageDefault != null)
        {
            button.image.sprite = imageDefault; // Revert to the default sprite on exit
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        myEventClick.Invoke();
        cont = 1;
    }

    public void quitar()
    {
        if (cont == 1)
        {
            canvas.enabled = false;
        }
    }
}
