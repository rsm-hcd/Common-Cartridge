using System.IO;

namespace CommonCartridge.Tests
{
    public abstract class ParserTestBase
    {
        #region Properties
        protected string RootFilePath
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "Data");
            }
        }
        #endregion
    }
}
