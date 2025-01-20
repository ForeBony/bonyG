using UnityEngine;

namespace Bony
{
    /// <summary>
    /// 列舉 enumeration  , enum
    /// </summary>

public class GameL5_2_Enumeration:MonoBehaviour
{
    //enumeration 定義下拉式選單的選項
    // 修飾詞 關鍵字 enum 列舉名稱 {列舉選項}
    // a enum name Season
    private enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    [SerializeField,Header("seasoN")]
    private Season seaSon=Season.Summer;

    private void Awake()
    {
        // get
        Debug.Log(seaSon);
        Debug.Log((int)seaSon);
        // set
        seaSon=Season.Winter;
        Debug.Log(seaSon);
        seaSon=(Season)2;
        Debug.Log(seaSon);
    }
    
    /// <summary>
    ///  Gear 列舉的數值----------------------------
    /// </summary>
    private enum ItEm
    {
        None=0,
        Coin=1,
        HealthyPotion=10, 
        ManaPotion=11,
        Chicken=20,
    }

    [SerializeField, Header("item")] 
    private ItEm iTem = ItEm.Chicken;
    /// <summary>
    /// 執行事件
    /// 開始事件 在喚醒事件後執行一次（初始化）Awake > start > update----
    /// 看須不需要決定是否使用 
    ///
    ///  啟動遊戲
    ///   第一個執行 awake
    ///   下一個是 start
    ///   之後都是 update
    ///  
    /// </summary>
    private void Start() // init
    {
        Debug.Log((int)iTem);
    }
    private void Update()
    {
        Debug.Log((int)iTem);
    }

}
}
