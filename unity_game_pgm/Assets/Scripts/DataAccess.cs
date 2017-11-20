//using System;
//using System.IO;
//using System.Runtime.InteropServices;
//using System.Runtime.Serialization.Formatters.Binary;
//using UnityEngine;
//
//public class DataAccess
//{
//	[DllImport("__Internal")]
//	private static extern void SyncFiles();
//
//	[DllImport("__Internal")]
//	private static extern void WindowAlert(string message);
//
//	public static void Save(GameDetails gameDetails)
//	{
//		string dataPath = string.Format("{0}/GameDetails.dat", Application.persistentDataPath);
//		BinaryFormatter binaryFormatter = new BinaryFormatter();
//		FileStream fileStream;
//
//		try
//		{
//			if (File.Exists(dataPath))
//			{
//				File.WriteAllText(dataPath, string.Empty);
//				fileStream = File.Open(dataPath, FileMode.Open);
//			}
//			else
//			{
//				fileStream = File.Create(dataPath);
//			}
//
//			binaryFormatter.Serialize(fileStream, gameDetails);
//			fileStream.Close();
//
//			if (Application.platform == RuntimePlatform.WebGLPlayer)
//			{
//				SyncFiles();
//			}
//		}
//		catch (Exception e)
//		{
//			PlatformSafeMessage("Failed to Save: " + e.Message);
//		}
//	}
//
//	public static GameDetails Load()
//	{
//		GameDetails gameDetails = null;
//		string dataPath = string.Format("{0}/GameDetails.dat", Application.persistentDataPath);
//
//		try
//		{
//			if (File.Exists(dataPath))
//			{
//				BinaryFormatter binaryFormatter = new BinaryFormatter();
//				FileStream fileStream = File.Open(dataPath, FileMode.Open);
//
//				gameDetails = (GameDetails)binaryFormatter.Deserialize(fileStream);
//				fileStream.Close();
//			}
//		}
//		catch (Exception e)
//		{
//			PlatformSafeMessage("Failed to Load: " + e.Message);
//		}
//
//		return gameDetails;
//	}
//
//	private static void PlatformSafeMessage(string message)
//	{
//		if (Application.platform == RuntimePlatform.WebGLPlayer)
//		{
//			WindowAlert(message);
//		}
//		else
//		{
//			Debug.Log(message);
//		}
//	}
//}