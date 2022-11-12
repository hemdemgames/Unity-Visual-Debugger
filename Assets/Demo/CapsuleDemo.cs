using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class CapsuleDemo : MonoBehaviour
    {
        [SerializeField] private float height = 2;
        [SerializeField] private float radius = .5f;
        [SerializeField] private Color color = Color.white;

        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawCapsule(transform.position, transform.up, height, radius);
        }
    }
}