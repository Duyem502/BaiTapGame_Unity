using UnityEngine;

public class WorldToScreen : MonoBehaviour
{
    void Update()
    {
        // Chuyển đổi vị trí của object từ World Space sang Screen Space
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        
        // In tọa độ ra bảng Console
        Debug.Log(screenPos);
    }
}