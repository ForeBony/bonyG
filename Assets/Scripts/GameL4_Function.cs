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
        for (int i = 0; i < 3; i++){
            FirstFunction(i);
            for (int j = 0; j < 3; j++)
            {
                UseSkill("T_T");    
            }
            
        }

        
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
    private void UseSkill(string skill)
    {
        Debug.Log($"<color=#f93>{skill}</color>");
    }
    
    
}



