﻿using System;

namespace HelloTicher
{
    public abstract class DisposeExample : IDisposable
    {
        private bool _disposed;
        public void Dispose()
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
    }
    public sealed class Derived : DisposeExample
    {
        private bool _isDisposed = false;

        protected override void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                }
                _isDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}
