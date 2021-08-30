using System;

namespace DefaultInterfaceImplementation
{
    #region Example1

    interface Logger
    {
        void Log(string message);

        void Log(Exception ex)
        {
            Log("Default implementation:" + ex.Message);
        }
    }

    class CustomLogger : Logger
    {
        public void Log(string message)
        {
            Console.WriteLine("Implemented:" + message);
        }

        public void Log(Exception ex)
        {
            Log("Overridden :" + ex.Message);
        }
    }

    #endregion Example1

    #region Example2

    interface Logger2
    {
        abstract void Log(string message);
        virtual void Log(Exception ex)
        {
            Log("Default implementation:" + ex.Message);
        }
    }

    class CustomLogger2 : Logger2
    {
        public void Log(string message)
        {
            Console.WriteLine("Implemented:" + message);
        }

        public void Log(Exception message)
        {
            Console.WriteLine("Overridden:" + message);
        }
    }

    #endregion Example2
}
