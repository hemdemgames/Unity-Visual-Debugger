using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class GizmoDrawer : Drawer
    {
        public Color color { get; set; }

        public override void DrawLine(Vector3 start, Vector3 end)
        {
            var defaultColor = Gizmos.color;
            Gizmos.color = color;
            Gizmos.DrawLine(start, end);
            Gizmos.color = defaultColor;
        }
    }
}
