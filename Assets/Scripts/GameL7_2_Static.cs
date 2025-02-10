using UnityEngine;

namespace bony
{
    

public class GameL7_2_Static:MonoBehaviour
{
    // 非靜態
    public int inventoryPotion = 10;
    // 靜態 : 修飾詞後面添加關鍵字static
    //靜態變數不顯示在屬性面板上 
    public static int inventoryProp = 20;

    private void Awake()
    {
        inventoryPotion = 7;
        inventoryProp = 15;
        Debug.Log($"<color=#fa9>{inventoryPotion}</color>");
        Debug.Log($"<color=#fa9>{inventoryProp}</color>");
    }

}
}