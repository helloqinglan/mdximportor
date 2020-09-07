using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_2020_2_OR_NEWER
using UnityEditor.AssetImporters;
#else
using UnityEditor.Experimental.AssetImporters;
#endif
using System.IO;

[ScriptedImporter(1, "m2")]
public class MdxImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        using (var reader = new BinaryReader(new FileStream(ctx.assetPath, FileMode.Open)))
        {
            
        }
    }
}
