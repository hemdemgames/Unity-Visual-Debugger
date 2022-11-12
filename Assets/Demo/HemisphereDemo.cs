using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class HemisphereDemo : MonoBehaviour
    {
        [SerializeField] private float radius = .5f;
        [SerializeField] private Color color = Color.white;

        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawHemisphere(transform.position, transform.up, radius);
        }
    }
}