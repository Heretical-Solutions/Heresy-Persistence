using UnityEngine;
using Zenject;
using HereticalSolutions.Repositories;

namespace HereticalSolutions.Persistence
{
	public class PersistentState : MonoBehaviour
	{
		[Inject]
		private IRepository<string, object> repository;

		[SerializeField]
		private string key;

		public string Key { get => key; set => key = value; }

		public bool StateSerialized
		{
			get
			{
				return repository.Has(key);
			}
		}

		public T GetStateGeneric<T>()
		{
			if (string.IsNullOrEmpty(key))
			{
				Debug.LogError("[PersistentState] INVALID KEY", gameObject);

				return default(T);
			}

			object result;

			if (!repository.TryGet(key, out result))
				return default(T);

			return (T)result;
		}

		public object GetStateObject()
		{
			if (string.IsNullOrEmpty(key))
			{
				Debug.LogError("[PersistentStateSerializer] INVALID KEY", gameObject);

				return null;
			}

			object result;

			if (!repository.TryGet(key, out result))
				return null;

			return result;
		}

		public void SetStateGeneric<T>(T data)
		{
			repository.AddOrUpdate(
				key,
				data);
		}

		public void SetStateObject(object data)
		{
			repository.AddOrUpdate(
				key,
				data);
		}

		public void RemoveState()
		{
			repository.Remove(key);
		}
	}
}