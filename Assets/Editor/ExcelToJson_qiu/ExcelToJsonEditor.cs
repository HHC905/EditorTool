using UnityEngine;
using System.Collections;
using System;
using UnityEditor;
using System.Linq;
using System.Text;
using System.IO;
public class ExcelToJsonEditor : EditorWindow
{

    [MenuItem("ExcelToJson/SeleteFile")]
    static void SeleteFile()
    {
        //绘制一个可视化窗口
        GetWindow<ExcelToJsonEditor>("ExcelToJson", true);
    }
    string myString = "SeleteFile";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;
    private Vector2 _scrollPosition = Vector2.zero;
    void OnGUI()
    {
        //绘制窗口的内容

        //绘制第一行标题
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        //绘制一个输入框，并且赋值给mystring
        myString = EditorGUILayout.TextField("seleteFile", myString);

        //绘制一个单选框Group，结果赋值给groupEnabled，在未定义结束之前都可以控制下面的绘制组件
        groupEnabled = EditorGUILayout.BeginToggleGroup("Endable", groupEnabled);
        //在单选框下面绘制一个开关，只有在Enable选中后才有用
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        //在单选框下面绘制一个滑动条，值赋值给myFloat，只有在Enable选中后才有用
        myFloat = EditorGUILayout.Slider("Slider", myFloat, 0, 1);

        //结束上面的单选框ToggleGroup
        EditorGUILayout.EndToggleGroup();


        //Toolbar
        GUILayout.BeginHorizontal(EditorStyles.toolbar);
        {
            if (GUILayout.Button("Save", EditorStyles.toolbarButton))
            {
                //Save();
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Build", EditorStyles.toolbarButton))
            {
                //execBuild = true;
            }
        }
        GUILayout.EndHorizontal();

        //context
        GUILayout.BeginVertical();
        {
            GUILayout.Space(10);

            //Filter item list
            _scrollPosition = GUILayout.BeginScrollView(_scrollPosition);
            {
               // _list.DoLayoutList();
            }
            GUILayout.EndScrollView();
        }
        GUILayout.EndVertical();
    }
}
