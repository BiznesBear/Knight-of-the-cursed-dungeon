using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonExit : MonoBehaviour
{
    public GameObject boss;
    public GameObject stonewall;

    private void Update()
    {
        if(boss == null)
        {
            Destroy(stonewall);
        }
    }
}
