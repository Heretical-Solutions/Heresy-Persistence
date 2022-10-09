using UnityEngine;
using System.IO;

namespace HereticalSolutions.Persistence.Settings
{
	/// <summary>
	/// Serialization settings specifying where to locate save files and providing shorthand methods to users
	/// </summary>
	[CreateAssetMenu(fileName = "SerializationSettings", menuName = "Settings/Serialization settings", order = 2)]
	public class SerializationSettings : ScriptableObject
	{
		/// <summary>
		/// Save file's relative path to save folder location
		/// </summary>
		public string RelativePath;

		/// <summary>
		/// Should the file be looked for in the resources folder
		/// </summary>
		public bool LoadFromResourcesFolder;

		/// <summary>
		/// Full file path
		/// </summary>
		public string FullPath
		{
			get
			{
				return LoadFromResourcesFolder
					? $"{Application.dataPath}/Resources/{RelativePath}"
					: Path.Combine(Application.persistentDataPath, RelativePath).Replace("\\", "/");
			}
		}

		/// <summary>
		/// File path for Resources.Load routine
		/// </summary>
		public string ResourcePath
		{
			get
			{
				int lastIndexOfSeparator = RelativePath.LastIndexOf('.');

				if (lastIndexOfSeparator == -1)
					return RelativePath;

				return RelativePath.Remove(lastIndexOfSeparator);
			}
		}
	}
}