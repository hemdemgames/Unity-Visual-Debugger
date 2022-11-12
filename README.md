# Unity-Visual-Debugger

<img src="screenshot.png?raw=true" alt="EzySlice Logo" width="600">

##### InGame Usages

```C#
using HemdemGames.VisualDebugger;

Visualizer.Debug.DrawArc(Vector3 center, Vector3 direction, Vector3 normal, float radius, float angle);
Visualizer.Debug.DrawCakeSlice(Vector3 center, Vector3 direction, Vector3 normal, float radius, float angle);
Visualizer.Debug.DrawPolyLine(Vector3[] points, bool loop);
Visualizer.Debug.DrawCircle(Vector3 center, Vector3 normal, float radius);
Visualizer.Debug.DrawCylinder(Vector3 center, Vector3 direction, float height, float radius);
Visualizer.Debug.DrawHemisphere(Vector3 center, Vector3 direction, float radius);
Visualizer.Debug.DrawSphere(Vector3 center, float radius);
Visualizer.Debug.DrawCapsule(Vector3 center, Vector3 direction, float height, float radius);
Visualizer.Debug.DrawRectangle(Vector3 center, Vector3 direction, Vector3 normal, Vector2 size);
Visualizer.Debug.DrawCube(Vector3 center, Vector3 direction, Vector3 normal, Vector3 size);
Visualizer.Debug.DrawArrow(Vector3 center, Vector3 direction, Vector3 normal, float length);
```

##### Gizmos Usages

```C#
using HemdemGames.VisualDebugger;

Visualizer.Gizmo.DrawArc(Vector3 center, Vector3 direction, Vector3 normal, float radius, float angle);
Visualizer.Gizmo.DrawCakeSlice(Vector3 center, Vector3 direction, Vector3 normal, float radius, float angle);
Visualizer.Gizmo.DrawPolyLine(Vector3[] points, bool loop);
Visualizer.Gizmo.DrawCircle(Vector3 center, Vector3 normal, float radius);
Visualizer.Gizmo.DrawCylinder(Vector3 center, Vector3 direction, float height, float radius);
Visualizer.Gizmo.DrawHemisphere(Vector3 center, Vector3 direction, float radius);
Visualizer.Gizmo.DrawSphere(Vector3 center, float radius);
Visualizer.Gizmo.DrawCapsule(Vector3 center, Vector3 direction, float height, float radius);
Visualizer.Gizmo.DrawRectangle(Vector3 center, Vector3 direction, Vector3 normal, Vector2 size);
Visualizer.Gizmo.DrawCube(Vector3 center, Vector3 direction, Vector3 normal, Vector3 size);
Visualizer.Gizmo.DrawArrow(Vector3 center, Vector3 direction, Vector3 normal, float length);
```
