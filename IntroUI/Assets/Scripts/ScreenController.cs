using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenController : MonoBehaviour
{
    [SerializeField]
    GameObject screenGame, screenIntro, player;

    [SerializeField]
    TMP_InputField inputPlayerName;

    [SerializeField]
    TextMeshProUGUI playerNameInGame;

    [SerializeField]
    TextMeshProUGUI errorLog;

    void Start()
    {
        screenGame.SetActive(false);
        player.SetActive(false);
        screenIntro.SetActive(true);
    }

    public void EmpezarJuego()
    {
        
        if (string.IsNullOrWhiteSpace(inputPlayerName.text))
        {
            //Mostrar error
            errorLog.text = "Introduce un nombre de usuario";
        }
        else
        {
            screenGame.SetActive(true);
            player.SetActive(true);
            screenIntro.SetActive(false);
            playerNameInGame.text = inputPlayerName.text;
        }
    }
}
