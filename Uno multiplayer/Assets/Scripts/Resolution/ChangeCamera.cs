using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public float pixelsPerUnit = 100f;
    public float minOrthographicSize = 5f;

    void Start()
    {
        float targetSize = (Screen.height / 2.0f) / pixelsPerUnit;
        Camera.main.orthographicSize = Mathf.Max(targetSize, minOrthographicSize);
    }
}
