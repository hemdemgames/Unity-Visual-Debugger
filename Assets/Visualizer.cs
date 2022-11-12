using UnityEngine;

namespace HemdemGames.VisualDebugger
{
    public static class Visualizer
    {
        private static GizmoDrawer gizmoDrawer;
        private static DebugDrawer debugDrawer;

        public static GizmoDrawer Gizmo
        {
            get
            {
                gizmoDrawer ??= new GizmoDrawer();
                return gizmoDrawer;
            }
        }

        public static DebugDrawer Debug
        {
            get
            {
                debugDrawer ??= new DebugDrawer();
                return debugDrawer;
            }
        }
    }

}
