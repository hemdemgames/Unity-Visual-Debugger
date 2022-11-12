using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class ArcDemo : MonoBehaviour
    {
        [SerializeField] private float radius = 1;
        [SerializeField] private float angle = 90;
        [SerializeField] private Color color = Color.white;

        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawArc(transform.position, transform.forward, transform.up, radius, angle);
        }
    }
}