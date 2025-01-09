using UnityEngine;
/// <summary>
///  開頭：觸發 XML 註解。
/// XML 格式：XML 註解使用特定的標籤來組織信息，支持描述、參數、返回值等。
/// </summary>
public class GameL2_dataType : MonoBehaviour
{
    public int count = 117;
    public float moveSpeed = 3.5f;
    public float turnSpeed = 30.7f;
    public string character = "Gern";
    public char cHaR = 'a';
    public bool isDead = false;
    public bool gameOver = true;
    public byte lv = 255; //byte  0~255, 8 byte
    public uint coin = 9999; //  32 byte
    public sbyte sB = -128;
}
