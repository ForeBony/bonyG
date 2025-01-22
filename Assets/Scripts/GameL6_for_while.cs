using UnityEngine;

namespace Bony
{
    
}
/// <summary>
/// for , foreach, do , while
/// </summary>

public class GameL6_for_while: MonoBehaviour
{
    // awake, start
    // while (bool) {code}
    private void Awake()
    {
        // while-----------------------
        int i = 0;
        while (i < 5 )
        {
            Debug.Log($"<color=#ffaa99> while: {i}</color>");
            i++;
        }
        
        // do------------------
        // do {code} while {bool}
        int j = 0;
        do
        {
            Debug.Log($"<color=#ff00ff> do: {j}</color>");
            j++;
        }
        while (j < 5);
        
        // for -----------------------
        // for (start ; bool ; step) {code}
        for (int k = 0; k < 5; k++)
        {
            Debug.Log($"<color=#33ff99> for: {k}</color>");
        }
        // foreach (資料類型 資料名稱 in 資料結構) {程式區塊}
        string dialogue = "hi im npc";
        
        
        
        foreach (var text in dialogue)
        {
            Debug.Log($"<color=#ffff66> foreach: {text}</color>");
        }


    }
    
}
