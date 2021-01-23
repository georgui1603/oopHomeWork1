using System;

public abstract class DisposeExample : IDisposeble
{
    private bool _disposed;
    public void Dicpose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {

            }
            _disposed = true;
        }
    }
    ~DisposeExample()
    {
        Dispose(false);
    }
    public sealed class Derived : DisposeExample
    {
        private bool _isDisposed = false;
        protected override void Dispose(bool disposing)
        {
            if (!_isDisposed)
            { 
                if (disposing)
            }

            _isDisposed = true;

        }

        base.Dispose(dispoing);
    }
}

public interface IDisposeble
{
   
}