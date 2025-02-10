using UnityEngine;

namespace bony
{


public class GameL7_1_GetData:MonoBehaviour
{
 public GameL7_property property1;

 private void Awake()
 {
     // get another class data
     Debug.Log(property1.movespeed);
     property1.movespeed = 7.7f;
     // Debug.Log(property1.movespeed);
     property1.runspeed = 7.7f;
     Debug.Log(property1.runspeed);
     // 唯讀
     Debug.Log(property1.jumpSpeed) ;
     
 }

}
}