﻿using System;

namespace WebDAVSharp.Server
{
    
    public abstract class WebDavDisposableBase : IDisposable
    {
private bool _isDisposed;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            _isDisposed = true;
        }

        /// <summary>
        /// This method will ensure that the object has not been disposed of through a call
        /// to
        /// <see cref="Dispose()" />, and if it has, it will throw
        /// <see cref="ObjectDisposedException" />
        /// </summary>
        /// <exception cref="System.ObjectDisposedException">The object has been disposed of.</exception>
        protected void EnsureNotDisposed()
        {
            if (_isDisposed)
                throw new ObjectDisposedException(GetType().FullName);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected abstract void Dispose(bool disposing);
    }
}
