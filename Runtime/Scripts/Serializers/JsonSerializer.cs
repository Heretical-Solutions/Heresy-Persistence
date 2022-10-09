using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using HereticalSolutions.Persistence.Settings;
using System.Collections.Generic;

namespace HereticalSolutions.Persistence.Serializers
{
	public partial class JsonSerializer : ISerializer
	{
		/// <summary>
		/// JSON.Net serialization settings for writing
		/// </summary>
		private JsonSerializerSettings writeSerializerSettings;

		/// <summary>
		/// JSON.Net serialization settings for reading
		/// </summary>
		private JsonSerializerSettings readSerializerSettings;

		public JsonSerializer()
		{
			writeSerializerSettings = new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.Auto,
				TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
				ReferenceLoopHandling = ReferenceLoopHandling.Ignore
			};

			readSerializerSettings = new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.Auto,
				TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
				MaxDepth = 10
			};
		}

		//TODO: implement in Heresy Databases and Repositories as partial
		/*
		/// <summary>
		/// Saves data from dictionary<string, object> to json file
		/// </summary>
		/// <param name="storage">Storage</param>
		/// <param name="settings">Serializiation settings</param>
		public void Save(Dictionary<string, object> storage, SerializationSettings settings)
		{
			string savePath = settings.FullPath;

			FileExists(savePath);

			string json = JsonConvert.SerializeObject(
				storage,
				Formatting.Indented,
				writeSerializerSettings);

			File.WriteAllText(savePath, json);
		}
        */

		/// <summary>
		/// Checks whether the file at the specified path exists
		/// - Also makes sure the folder directory specified in the path actually exists anyway
		/// </summary>
		/// <param name="path">Path to the file</param>
		/// <returns>Does the file exist</returns>
		private bool FileExists(string path)
		{
			bool result = true;

			string directoryPath = Path.GetDirectoryName(path);

			if (!Directory.Exists(directoryPath))
			{
				Directory.CreateDirectory(directoryPath);

				result = false;
			}

			if (result)
				result &= File.Exists(path);

			return result;
		}

		//TODO: implement in Heresy Databases and Repositories as partial
		/*
		/// <summary>
		/// Populates data to dictionary<string, object> from json file
		/// </summary>
		/// <param name="storage">Storage</param>
		/// <param name="settings">Serializiation settings</param>
		public void Load(Dictionary<string, object> storage, SerializationSettings settings)
		{
			string savePath = settings.FullPath;

			if (FileExists(savePath))
			{
				var loadedData = settings.LoadFromResourcesFolder
					? Resources.Load<TextAsset>(settings.ResourcePath).text
					: File.ReadAllText(savePath);

				JsonConvert.PopulateObject(loadedData, storage, readSerializerSettings);
			}
		}
        */

		/// <summary>
		/// Erases json file
		/// </summary>
		/// <param name="settings">Serializiation settings</param>
		public void Erase(SerializationSettings settings)
		{
			string savePath = settings.FullPath;

			if (File.Exists(savePath))
				File.Delete(savePath);
		}
	}
}