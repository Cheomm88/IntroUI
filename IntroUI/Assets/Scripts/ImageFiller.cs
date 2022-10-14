using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFiller : MonoBehaviour
{

    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.5f;
    }

    public void Fill(float valor)
    {
        image.fillAmount += valor;
    }

}
