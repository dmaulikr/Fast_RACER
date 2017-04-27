using UnityEngine;
using System.Collections;

public interface ISpriteSheetParser 
{
	bool ParseAsset(Texture2D asset, TextAsset textAsset);
}