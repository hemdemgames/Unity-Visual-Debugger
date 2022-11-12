using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class CubeDemo : MonoBehaviour
    {
        [SerializeField] private Vector3 size = Vector3.one;
        [SerializeField] private Color color = Color.white;

        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawCube(transform.position, transform.forward, transform.up, size);
        }
    }
}