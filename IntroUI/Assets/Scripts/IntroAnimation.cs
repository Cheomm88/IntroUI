using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject logo;
    [SerializeField]
    GameObject mainMenu;
    
    void Start()
    {
        //Oculto mi logo. De manera inmediata, en cero segundos.
        LeanTween.moveLocalY(logo, -780f, 0.0f);
        //Hago aparecer el logo desde su posición hacia la posición 110f en el eje Y 
        //animación que dura 1.0 segundos
        LeanTween.moveLocalY(logo, 110f, 1.0f).setEaseInOutBounce().setOnComplete(Latido);

        //Para moverlo localmente en ambos ejes
        //LeanTween.moveLocal(logo, new Vector2(670f, 72f), 1.5f);
    }

    void Latido()
    {
        LeanTween.scale(logo, Vector3.one, 0.25f).setEaseOutBack().setOnComplete( () => {
            LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Desactivar);        
        });
    }

    void Desactivar()
    {
        gameObject.SetActive(false);
        //Activar el menu principal...
        mainMenu.SetActive(true);

    }


}
