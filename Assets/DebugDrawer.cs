using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public class DebugDrawer : Drawer
    {
        public float duration { get; set; }
        public Color color { get; set; }

        public DebugDrawer()
        {
            this.color = Color.white;
            this.duration = 0;
        }

        public override void DrawLine(Vector3 start, Vector3 end)
        {
            Debug.DrawLine(start, end, color, duration);
        }
    }
}