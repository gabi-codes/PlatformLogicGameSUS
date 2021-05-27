using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public int lvlId = 3;
    public bool[] amogs = new bool[] { true, false, true, true, false, false, false, false, false, false, true, false, false, true, false };
    public bool[] lvlUn = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

    public PlayerData ()
    {
        lvlId = InteractibleA.lvlIndex;

        for (int n = 0; n < 15; n++)
        {
            amogs[n] = Static.AMOGS[n];
        }
        

        for (int n = 0; n < 16; n++)
        {
            lvlUn[n] = InteractibleA.lvlUnlock[n];
        }

        lvlUn = InteractibleA.lvlUnlock;
    }
}
