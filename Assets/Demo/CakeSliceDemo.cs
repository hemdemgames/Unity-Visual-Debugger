using System;
using UnityEngine;
using System.Collections;

namespace HemdemGames.VisualDebugger
{
    public class CakeSliceDemo : MonoBehaviour
    {
        [SerializeField] private float angle = 90;
        [SerializeField] private float radius = 1;
        [SerializeField] private Color color = Color.white;
        
        private void OnDrawGizmos()
        {
            Visualizer.Gizmo.color = color;
            Visualizer.Gizmo.DrawCakeSlice(transform.position, transform.forward, transform.up, radius, angle);
        }
    }
}