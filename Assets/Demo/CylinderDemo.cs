using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class CylinderDemo : MonoBehaviour
    {
        [SerializeField] private float height = 2f;
        [SerializeField] private float radius = .5f;
        [SerializeField] private Color color = Color.white;

        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawCylinder(transform.position, transform.up, height, radius);
        }
    }
}