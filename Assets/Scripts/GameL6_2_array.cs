using UnityEngine;

namespace Bony
{
    
}

public class GameL6_2_array : MonoBehaviour
{
    // 皮卡秋 小火龍 比卡受
    public string
        card1 = "pikachu",
        card2 = "fire dragon",
        card3 = "KaPiSol";

    // array 用來存多筆相同類型的資料
    // 第一種 不指定值 透過unity輸入
    //修飾詞 資料類型 [] 陣列名稱;
    public string[] cards;

    //定義一個牌組 可以放五張卡排
    public string[] deck1 = new string[5];

    // 直接定義陣列的值
    public string[] deck2 =
    {
        "aa",
        "bb",
        "寶石海星",
    };

    public string[,] inventory =
    {
        { "b00", "b01" },
        { "c00", "c01" },
        { "d00", "d01" }
    };

    public string[,,] shop =
    {
        {
            {
                "a01", "a02"
            },
            {
                "b01", "b02"
            }
        },
        {
            {
                "c01", "c02"
            },
            {
                "d01", "d02"
            }
        }
    };
    
    //不規則陣列 定義陣列
    private int[][] numbers=new int[2][];
    private int[][,] count =new int[2][,];
    

    private void Start()
    {
        // 存取陣列 Set Get
        //Get
        //陣列名稱[編號]
        Debug.Log($"<color=#00ff00>deck2: {deck2[2]}</color>");

        // set 設定陣列的資料
        // 陣列名稱[編號] 指定 值
        // 將寶石海星換成節泥歸
        deck2[2] = "節泥歸";
        Debug.Log($"<color=#00ffff>deck2[2]: {deck2[2]}</color>");

        // 存取二維陣列
        Debug.Log($"<color=#ffaa66>inventory[0,1]: {inventory[0, 1]}</color>");
        Debug.Log($"<color=#ffaa66>inventory[1,1]: {inventory[1, 1]}</color>");
        inventory[1, 1] = "好商要";
        Debug.Log($"<color=#ffaa66>modify==>inventory[1,1]: {inventory[1, 1]}</color>");

        Debug.Log($"<color=#ffff99>modify shop[0,1,0]</color>====><color=#ffcc99>{shop[0, 1, 0]}</color>");
        shop[0, 1, 0] = "超級球";
        Debug.Log($"<color=#ffff99>modify shop[0,1,0]</color>====><color=#ffcc99>{shop[0, 1, 0]}</color>");

        //獲得 陣列長度 維度  ---------------------------
        //陣列名稱.Length
        Debug.Log($"<color=#aa66ff>length deck2.Length===> {deck2.Length}</color>");
        Debug.Log($"<color=#aa66ff>length shop.Length===> {shop.Length}</color>");
        // 維度
        // 陣列名稱.Rank
        Debug.Log($"<color=#aa66ff>length deck2.Rank===> {deck2.Rank}</color>");
        Debug.Log($"<color=#aa66ff>length shop.Rank===> {shop.Rank}</color>");
        
        //不規則陣列 陣列內容
        numbers[0] = new int[] {1,3,5};
        numbers[1] = new int[] {9,8};
        //取得數字3和9
        Debug.Log($"<color=#3ff>不規則陣列的數字3: {numbers[0][1]}</color>");
        Debug.Log($"<color=#3ff>不規則陣列的數字9: {numbers[1][0]}</color>");
        //將8改成6
        numbers[1][1] = 6;
        Debug.Log($"<color=#3ff>第二列第二個: {numbers[1][1]}</color>");
        
        // 不規則陣列 包含多維陣列
        count[0] = new int[,] { { 1, 1 }, { 1, 1 } };
        count[1] = new int[,] { { 2, 2 ,2}, { 2, 2 ,2 } };
        Debug.Log($"<color=#3ff>count 第二列 [0,0]{count[1][0,0]}</color>");


    }


}
