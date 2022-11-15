using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject panel;

    public void togglepanel(GameObject panel)
    {
        panel.SetActive(!panel.active);
    }
}
