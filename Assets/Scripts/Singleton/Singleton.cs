using UnityEngine;

namespace RadgarGames.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _instance;

        public static T Instance => GetInstance();

        private static T GetInstance()
        {
            if (_instance == null) FindInstance();
            return _instance;
        }

        private static void FindInstance()
        {
            var singleton = FindObjectOfType<T>();

            if (singleton == null)
                Debug.LogError($"No Object With Script: {typeof(T).Name} found in the scene.");
            else
                _instance = singleton;
        }
    }
}
