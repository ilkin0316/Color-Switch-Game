using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public string whatsappurl;
    public string telegramurl;
    public string instagramurl;

    public void whatsappurl_ac()
    {
        Application.OpenURL(whatsappurl);
    }

    public void telegramurl_ac()
    {
        Application.OpenURL(telegramurl);
    }

    public void instagramurl_ac()
    {
        Application.OpenURL(instagramurl);
    }
}
