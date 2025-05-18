using UnityEngine;

[ExecuteAlways]
public class CameraBoundsGizmo : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Camera cam = GetComponent<Camera>();
        if (cam == null || !cam.orthographic) return;

        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        Vector3 center = cam.transform.position;

        Gizmos.color = Color.green;

        // Рисуем прямоугольник камеры
        Gizmos.DrawLine(center + new Vector3(-width / 2, -height / 2, 0), center + new Vector3(-width / 2, height / 2, 0));
        Gizmos.DrawLine(center + new Vector3(-width / 2, height / 2, 0), center + new Vector3(width / 2, height / 2, 0));
        Gizmos.DrawLine(center + new Vector3(width / 2, height / 2, 0), center + new Vector3(width / 2, -height / 2, 0));
        Gizmos.DrawLine(center + new Vector3(width / 2, -height / 2, 0), center + new Vector3(-width / 2, -height / 2, 0));
    }
}
