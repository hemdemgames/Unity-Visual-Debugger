using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class ArrowDemo : MonoBehaviour
    {
        [SerializeField] private float length = 1;
        [SerializeField] private float paddleLength = .2f;
        [SerializeField] private Color color = Color.white;

        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawArrow(transform.position, transform.forward, transform.up, length, paddleLength);
        }
    }
}