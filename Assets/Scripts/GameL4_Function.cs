using System;
using UnityEngine;
/// <summary>
/// 方法 函式 函數
/// function method(unity)
/// </summary>
public class GameL4_Function:MonoBehaviour
{
    public int test = 34;
    private void Awake()
    {
        for (int i = 1; i < 4; i++){
            FirstFunction(i);
            for (int j = 1; j < 4; j++)
            {
                SpawnEnemy();
                UseSkill("T_T",30);
                SpawnEnemy("Slim");
                UseSkill("o_o",50);
                
                Fire(100+j*i*4);
                Fire(200+j*i*10,"fire wood");
            }
            BuyItem(count:120);
            BuyItem("Mana Potion");
            BuyItem(count:150,item:"Mana Potion");

            float number9 = Square(9);
            Debug.Log($"<color=yellow>square calculate ==> {number9}</color>");
            Debug.Log($"<color=yellow>square calculate ==> {Square(7)}</color>");
        }
        
        Debug.Log($"<color=#3ff>BMI calculate==>{BMI(168, 60)}</color>");
        Move();
        Move(16.3f);

    }
    //方法
    //包含一系列程式區塊
    //修飾詞 傳回資料類型 方法名稱（） 程式區塊
    // unity 習慣使用大寫開頭命名
    // void 無傳回 用此方法不會有回傳資料
    private void FirstFunction(int a)
    {
        Debug.Log($"First function 123: ======== {a+1} ==========");
    }
    private void UseSkill(string skill,float cost)
    {
        Debug.Log($"<color=#f93>skill: {skill}</color>");
        Debug.Log($"<color=#f93>skill cost: {cost}</color>");
    }
    private void SpawnEnemy(string enemy="Goblem")
    {
        Debug.Log($"<color=#6f3>Gen enemy: {enemy}</color>");
    }
    ///<summary>
    ///  ShooT
    ///</summary>
    ///<param name="speed">shoot speeD</param>;
    ///<param name="fire">shoot objecT</param>;
    private void Fire(int speed, string fire="Fire Arrow")
    {
        Debug.Log($"<color=#ff3>fire: {fire},speed:{speed}</color>");
    }
    
    /// <summary>
    ///  Buy Item
    /// </summary>
    /// <param name="item">Item NamE</param>
    /// <param name="count">Item counT</param>
    private void BuyItem(string item = "Life Potion",int count = 50)
    {
        Debug.Log($"<color=#3f3>Buy item: {item}, count: {count}</color>");
    }
    
    #region Square Calculation
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"> number for calculate </param>
    /// <returns>Sqare Calculate</returns>
    private float Square(float number)
    {
        return number * number;
    }
    #endregion

    #region BMI Calculate
    /// <summary>
    /// Bmi Calculate
    /// </summary>
    /// <returns></returns>
    private float BMI(float height, float weight)
    {
         height /=100;
         float bmI = weight / Square(height);
         return bmI;
    }
    #endregion

    #region function overload
    /// <summary>
    /// 多載 參數的類型和數量不同
    /// </summary>
    private void Move()
    {
        Debug.Log("<color=yellow>MovE TexT</color>");
    }
    private void Move(float speed)
    {
        Debug.Log($"<color=yellow>MovE speed: {speed}</color>");
    }
    #endregion

}



