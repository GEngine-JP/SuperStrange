using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class AltasTools : Editor
{

    [MenuItem("AltasTools/MakeAtlas")]
    static private void MakeAtlas()
    {
        string spriteDir = Application.dataPath + "/Resources/Sprite";
        GameObject o = null;

        if (!Directory.Exists(spriteDir))
        {
            Directory.CreateDirectory(spriteDir);
        }

        DirectoryInfo rootDirInfo = new DirectoryInfo(Application.dataPath + "/Atlas");
        DirectoryInfo[] infoList = rootDirInfo.GetDirectories();

        foreach (DirectoryInfo dirInfo in infoList)
        {
            foreach (FileInfo pngFile in dirInfo.GetFiles("*.png", SearchOption.AllDirectories))
            {
                string allPath = pngFile.FullName;
                string assetPath = allPath.Substring(allPath.IndexOf("Assets"));
                Sprite sprite = AssetDatabase.LoadAssetAtPath<Sprite>(assetPath);
                o = new GameObject(sprite.name);
                o.AddComponent<SpriteRenderer>().sprite = sprite;
                allPath = spriteDir + "/" + sprite.name + ".prefab";
                string prefabPath = allPath.Substring(allPath.IndexOf("Assets"));
                PrefabUtility.CreatePrefab(prefabPath, o);
            }
        }

        GameObject.DestroyImmediate(o);
        Debug.Log("MakeAtlas Complete !");
    }


    [MenuItem("AltasTools/Build Assetbundle")]
    static private void BuildAssetBundle()
    {
        string dir = Application.dataPath + "/StreamingAssets";

        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        DirectoryInfo rootDirInfo = new DirectoryInfo(Application.dataPath + "/Atlas");
        foreach (DirectoryInfo dirInfo in rootDirInfo.GetDirectories())
        {
            List<Sprite> assets = new List<Sprite>();
            string path = dir + "/" + dirInfo.Name + ".assetbundle";
            foreach (FileInfo pngFile in dirInfo.GetFiles("*.png", SearchOption.AllDirectories))
            {
                string allPath = pngFile.FullName;
                string assetPath = allPath.Substring(allPath.IndexOf("Assets"));
                assets.Add(AssetDatabase.LoadAssetAtPath<Sprite>(assetPath));
            }
            if (BuildPipeline.BuildAssetBundle(null, assets.ToArray(), path, BuildAssetBundleOptions.UncompressedAssetBundle | BuildAssetBundleOptions.CollectDependencies, GetBuildTarget()))
            {
            }
        }

        Debug.Log("Build Assetbundle Complete !");
    }

    static private BuildTarget GetBuildTarget()
    {
        BuildTarget target = BuildTarget.WebPlayer;
#if UNITY_STANDALONE
			    target = BuildTarget.StandaloneWindows;
#elif UNITY_IPHONE
			    target = BuildTarget.iPhone;
#elif UNITY_ANDROID
        target = BuildTarget.Android;
#endif
        return target;
    }

}
