using System;
using UnityEngine;

public class GameL3_Operators:MonoBehaviour
{
    #region 基本的欄位屬性
    // 標題： 屬性面板上顯示標題文字---------------------------
    [Header("Level")]
    public int lv = 1;
    
    // [提示文字: 在屬性面板滑鼠停留在變數上會顯示]
    [Tooltip("This is movespeed of char,not recommended over 100")] 
    public float moveSpeed = 2.5f;
    
    // 設定範圍（最小，最大值）面板上會變成滑桿 須為數字類
    [Range(1,100)] 
    public byte count = 10;
    
    [TextArea(2,5)] // 文字範圍(最小行,最大行)
    public string itemDescription = "this is the description of weapon";
    #endregion
    
    // 多個欄位屬性---------------------------------------------
    [Header("liFe")][Range(0,999)]
    public int life = 100;
    [Header("AttaCk"), Range(0, 999)] public float attack = 30.5f;
    
    // 在屬性面板隱藏 把公開變數 隱藏
    [HideInInspector] public string password = "im not password";
    // 序列化欄位：將私人變數顯示
    [SerializeField]
    private float mp = 500;

    
    // event--------------------------------------------
    //必須在腳本後面添加：MonoBehaviour
    //使用關鍵字
    //喚醒事件 播放遊戲後會執行的第一個事件 只執行一次
    // 事件是藍色的
    private void Awake()
    {
        Debug.Log("Hellow world");
        Debug.Log(life);
        Debug.Log("Attack Power:"+attack);
        Debug.Log($"Attack Power:{attack}");
        // Rich Text
        Debug.Log("<b> bolT</b>");
        Debug.Log("<color=#44ff00>greEn</color>");
        
        // Operator
        // 算術運算子 加減乘除 + - * / 
        Debug.Log("<color=#44ff00>-----算術運算子-----</color>");
        Debug.Log(10+3);
        Debug.Log(10-3);
        Debug.Log(10*3);
        Debug.Log(10/3);
        Debug.Log(10%3);
        
        //區域變數 這在這個大括號中存取 (不需要修飾詞的變數)
        Debug.Log("<color=#ffaa00>-----算術運算子-----</color>");
        float numberA = 10;
        float numberB = 3;
        Debug.Log(numberA+numberB);
        Debug.Log(numberA-numberB);
        Debug.Log(numberA*numberB);
        Debug.Log(numberA/numberB);
        Debug.Log(numberA%numberB);
        
        // 比較運算子
        Debug.Log("<color=#ffaa00>-----比較運算子-----</color>");
        int numberC = 100, numberD = 1;
        Debug.Log(numberC > numberD);
        Debug.Log(numberC < numberD);
        Debug.Log(numberC >= numberD);
        Debug.Log(numberC <= numberD);
        Debug.Log(numberC != numberD);
        Debug.Log(numberC == numberD);
        


    }
}


