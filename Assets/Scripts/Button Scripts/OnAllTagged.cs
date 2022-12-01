using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAllTagged : MonoBehaviour
{
    public List<GameObject> evil;
   public void REVENGE()
   {
        foreach( GameObject go in evil) {
            go.SetActive(true);
        }
   }
}
