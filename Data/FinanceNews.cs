using System;

namespace BlazorFinanceNews.Data
{
    public class FinanceNews : IDisposable
    {
        private bool disposedValue;

        public string title { get; set; }

        public string link { get; set; }

        public DateTime pubDate { get; set; }

        public string source { get; set; }

        public string guid { get; set; }



        public void Dispose() => Dispose(true);


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }



    }
}
