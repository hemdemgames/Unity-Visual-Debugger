using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class SphereDemo : MonoBehaviour
    {
        [SerializeField] private float radius = 1f;
        [SerializeField] private Color color = Color.white;

        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawSphere(transform.position, radius);
        }
    }
}