using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class RectangleDemo : MonoBehaviour
    {
        [SerializeField] private Vector2 size = Vector2.one;
        [SerializeField] private Color color = Color.white;
        
        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawRectangle(transform.position, transform.forward, transform.up, size);
        }
    }
}