using UnityEngine;

public class practice4:MonoBehaviour
{
    public float power=1600.3f;
    public int mana=38;
    private void Awake()
    {
        Debug.Log(overPower());
        Debug.Log(overPower(power));   
        bool exH = exhausted(0);
        Debug.Log($"<color=#ffaa00>{exH}</color>");
        Debug.Log($"<color=#aa66ff>{exhausted(mana)}</color>");
            
    }

    private string overPower(float power=230)
        {
            if (power > 600.36)
            {
                return ($"overPower: <color=#ff6600>{power>600.36}</color>, POWER:{power}=====================");
            }
            else if (power < 0)
            {
                return ($"{power}, error occured====================");
            }
            else
            {
                return ($"overPower: <color=#55ff00>{power>600.36}</color>, POWER:{power}=============================");
            }
        }

    private bool exhausted(int ma)
    {
        return ma == 0;
    }
        
    
    
    
}
