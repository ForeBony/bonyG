using Unity.VisualScripting;
using UnityEngine;
// 命名空間 類似倉庫 不同倉庫可以有相同名稱類別
// 語法： namespace 命名空間名稱 {內容}
namespace Bony
{
    

/// <summary>
/// Selection Statement
/// 1. if
/// 2. switch
/// </summary>
public class GameL5_selection_if_else:MonoBehaviour
{
    //---------------------------------------
    // 設定為private 只有自己可看 並且用 serializeField 顯示 
    [SerializeField,Header("is open door??")]
    private bool isOpen;
    [SerializeField,Header("Score"),Range(0,100)]
    private int score=100;
    [SerializeField, Header("weapoN 1")] 
    private string weapon01;
    [SerializeField, Header("Life"),Range(0,100)] 
    private int LifE;
    
    //-------------------------------
    private void Awake(){
        if (true)
        {
           Debug.Log("this is true"); 
        }
        if (false)
        {
            Debug.Log("this is false");
        }
    }

    // 更新事件 一秒執行60次----------------------------
    private void Update()
    {
        Debug.Log("<color=green>Update event ===</color>");
        if (isOpen)
        {
            Debug.Log("<color=#0099ff>Update: this is true</color>");
        }
        else
        {
            Debug.Log("<color=#ff0000>Update: this is false</color>");
        }

        if (score >= 60)
        {
            Debug.Log("<color=#44aaff>Score: pass</color>");
        }
        else if (score >= 40)
        {
            Debug.Log("<color=#ffaa44>Score: exam again</color>");
        }
        else if (score >= 20)
        {
            Debug.Log("<color=#8866ff>Score: exam again with a project </color>");
        }
        else
        {
            Debug.Log("<color=#ff0000>Score: fail</color>");
        }
        
        //switch--------------------------
        // switch (value) { }
        switch (weapon01)
        {
            //case value;
            //when value ==10 , execute here;
            //break;
            case "butterfly" :
            case "Knife":
                Debug.Log("<color=#ffaa00> attack: 20</color>");
                break;
            case "art knife":
                Debug.Log("<color=#aaff33>atk: haha is that a joke? :D</color>");
                break;
            // when weapon not in the before options
            default:
                Debug.Log("<color=#ff0000> dont have this weapon </color>");
                break;
        }
        
            // practice ------------------
            if (LifE >= 80)
            {
                Debug.Log("<color=#00ffff>Life : Safe now</color>");
            }
            else if (LifE >= 60)
            {
                Debug.Log("<color=#00ff66>Life : becareful</color>");
            }
            else if (LifE >= 40)
            {
                Debug.Log("<color=#8866ff>Life : Need Life Potion now</color>");
            }
            else if (LifE >= 10)
            {
                Debug.Log("<color=#ffaa55>Life : almost die </color>");
            }
            else if (LifE == 0)
            {
                Debug.Log("<color=#ff6666>Life : press ESC restart </color>");
            }
            else
            {
                Debug.Log("<color=#ff0000>game not end??</color>");
            }
        
        
        
        
    }
}
}