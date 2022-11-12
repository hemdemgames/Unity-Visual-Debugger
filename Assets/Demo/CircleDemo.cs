using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class CircleDemo : MonoBehaviour
    {
        [SerializeField] private float radius = .5f;
        [SerializeField] private Color color = Color.white;

        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawCircle(transform.position, transform.up, radius);
        }
    }
}