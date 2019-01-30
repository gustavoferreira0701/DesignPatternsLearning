namespace DesignPatternsLearning.Singleton
{
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton() { }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                return InnerClass.Instance;
            }
        }

        private class InnerClass
        {
            /*
             * Important to mark this constructor as 'static', in order to tell 
             * C# Compiler not to mark type as beforefieldinit <- (Search more about this)
             * Otherwise, the 'lazyness' feature will be lost, I guess.
             */
            static InnerClass() { }

            internal static ThreadSafeSingleton Instance => new ThreadSafeSingleton();
        }
    }
}
