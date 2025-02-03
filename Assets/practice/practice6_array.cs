using System;
using UnityEngine;

namespace bony
{
    

public class practice6_array:MonoBehaviour
{
    [SerializeField, Header("test123")] private string test = "testt1";
    public string[,,] arR =
    {
        {
            {
                "pikachu","Richu"   
            } ,
            {
                "pikachu2","Richu2"
                    
            },
            {
                "pikachu3","Richu3"
            }
        },
        {
            {
                "guguSweetHeart","guguSweetHeart+1"    
            },
            {
                "guguSweetHeart1","guguSweetHeart+11"
                    
            },
            {
                "guguSweetHeart2","guguSweetHeart+12"
            }
              
        },
        {
            {
                "Guilun","Guilun+1"    
            },
            {
                "Guilun1","Guilun+11"
                    
            },
            {
                "Guilun2","Guilun+12"
            }
        }
    } ;

    private void Start()
    {
        Debug.Log($"page2,row1,slot2: {arR[1, 0, 1]}");

    }
}
}