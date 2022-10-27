using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScreen : MonoBehaviour
{
    [SerializeField]
    GameObject content;
    [SerializeField]
    GameObject mainMenu;


    public void EnterOptions()
    {
        CloseMainMenu();
    }

    public void CloseMainMenu()
    {
        LeanTween.scale(mainMenu, Vector3.one * 0.75f, 0.5f).setEaseOutBounce().setOnComplete(()=> { mainMenu.SetActive(false); Animate(); });
        //LeanTween.alphaCanvas(mainMenu.GetComponent<CanvasGroup>(), 0.0f, 0.3f).setOnComplete(Animate);
    }
    public void Animate()
    {
        
        LeanTween.scale(content, Vector3.zero, 0.0f);
        gameObject.SetActive(true);
        LeanTween.scale(content, Vector3.one, 0.5f);
    
    }

    public void ReturnMainMenu()
    {
        LeanTween.scale(content, Vector3.zero, 0.5f).setOnComplete(() => {
            LeanTween.moveLocalX(mainMenu, -1300f, 0.0f);
            LeanTween.scale(mainMenu, Vector3.one, 0.5f).setEaseOutBounce().setOnComplete(() => { mainMenu.SetActive(true); });            
            LeanTween.moveLocalX(mainMenu, -520f, 0.5f);
            LeanTween.alphaCanvas(mainMenu.GetComponent<CanvasGroup>(), 1.0f, 0.5f);
        });        
    }

    
}
