using UnityEngine;

namespace bony
{
    
}

public class practice5_switch:MonoBehaviour
{
    [SerializeField,Header("test here")]
    private string tesT = "test123";
    [SerializeField,Header("Healty point"),Range(0,100)]
    private int Hp = 100;
    
    private void Update()
    {
        switch (Hp)
        {
            case >=80:
                Debug.Log($"practice5 Hp==>{Hp}, Healty point is Good");
                break;
            case >=60:
                Debug.Log($"practice5 Hp==>{Hp}, Healty point is not Good");
                break;
            case >=40:
                Debug.Log($"practice5 Hp==>{Hp}, Drink water");
                break;
            case >=10:
                Debug.Log($"practice5 Hp==>{Hp}, almost Die");
                break;
            case 0:
                Debug.Log($"practice5 Hp==>{Hp}, press ESC restart");
                break;
                
            
        }
        
    }

}
