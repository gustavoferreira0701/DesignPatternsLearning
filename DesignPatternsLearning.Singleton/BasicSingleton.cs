namespace DesignPatternsLearning.Singleton
{
    public class BasicSingleton
    {
        public static BasicSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BasicSingleton();
                }

                return _instance;
            }
        }

        private static BasicSingleton _instance;

        private BasicSingleton() { }
    }
}
