using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RoomNodeGraphEditor : EditorWindow
{
    private GUIStyle roomNodeStyle;

    // Node Layout Values
    private const float nodeWidth = 160f;
    private const float nodeHeight = 75f;
    private const int nodePadding = 25;
    private const int nodeBorder = 12;

    // Create a new Menu Item Called "Room Node Graph Editor" Just like Hierarcy window but blank. We could access it by clicking
    // Window>Dungeun Editor>Room Node Graph Editor
    [MenuItem("Room Node Graph Editor", menuItem = "Window/Dungeun Editor/Room Node Graph Editor")]

    // Function to open the menu item that we created
    private static void OpenWindow()
    {
        GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");
    }

    private void OnEnable()
    {
        // Define Node Layout Style
        roomNodeStyle = new GUIStyle();
        roomNodeStyle.normal.background = EditorGUIUtility.Load("node1") as Texture2D;
        roomNodeStyle.normal.textColor = Color.white;
        roomNodeStyle.padding = new RectOffset(nodePadding, nodePadding, nodePadding, nodePadding);
        roomNodeStyle.border = new RectOffset(nodeBorder, nodeBorder, nodeBorder, nodeBorder);
    }

    // Draw Editor GUI
    private void OnGUI()
    {
        // Create a node within a certain defined position
        GUILayout.BeginArea(new Rect(new Vector2(100f, 100f), new Vector2(nodeWidth, nodeHeight)), roomNodeStyle);
        // Display Label
        EditorGUILayout.LabelField("Node 1");
        GUILayout.EndArea();

        // Create a node within a certain defined position
        GUILayout.BeginArea(new Rect(new Vector2(300f, 300f), new Vector2(nodeWidth, nodeHeight)), roomNodeStyle);
        // Display Label
        EditorGUILayout.LabelField("Node 2");
        GUILayout.EndArea();
    }
}
