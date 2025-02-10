using System;
using UnityEditor;
using UnityEngine;

namespace bony
{
    

public class GameL7_property:MonoBehaviour
{
    // public var
    public float movespeed = 3.5f;
    // private float
    private float spinspeed = 12.7f; 
    
    // 公開的屬性 
    public float runspeed { get; set; }
    // 私人屬性
    private float sprintspeed { get; set; }
    //公開 但唯讀
    public float jumpSpeed { get; }
    
    // enter[prop] +tab *2
    public byte lv { get; set; } = 1;
    
    // 屬性簡寫
    public float hp { get; set; } = 100;

    // 屬性標準寫法
    private float _mp= 50;
    public float mp 
    {
        get
        {
            return _mp;
        }
        set
        {
            _mp = value;
        }
    }
    
    // 取得屬性的簡寫(箭頭 =>  Lambda)
    // 唯獨屬性 值是30
    public int defence { get; } = 30;
    // 唯獨屬性 值是50 簡寫方法 
    public int attack => 50;
    


    private void Start()
    {
         //  get set
        Debug.Log($"<color=#77f>{mp}</color>");
        mp = 500;
        Debug.Log($"<color=#fa5>{mp}</color>");
    }

    //----------------------------
    private void Awake()
    {
     Debug.Log("------------------");
     Debug.Log(movespeed);
     Debug.Log(spinspeed);
     Debug.Log(sprintspeed);
     Debug.Log(jumpSpeed);
     movespeed =11.1f;
     spinspeed = 2.5f;
     sprintspeed = 60.2f;
     
    }
}
}