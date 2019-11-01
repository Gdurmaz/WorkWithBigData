using System;

namespace Project.Core.Helper
{
    public class TryCatchAction
    {
        public void TryCatchFinally(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"hata:{ex.Message} ,\n hata kodu:{ex.Source}");
            }
        }
    }
}
