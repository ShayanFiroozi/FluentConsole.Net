﻿/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System.Threading;



namespace FluentConsoleNet.Helpers
{
    internal static class SlimReadWriteLock
    {
        private static readonly ReaderWriterLockSlim Lock = new ReaderWriterLockSlim();


        internal static void GainReadLock() => Lock.EnterReadLock();
        internal static void GainWriteLock() => Lock.EnterWriteLock();

        internal static void ReleaseReadLock()
        {
            if (Lock.IsReadLockHeld)
            {
                Lock.ExitReadLock();
            }
        }

        internal static void RelaseWriteLock()
        {
            if (Lock.IsWriteLockHeld)
            {
                Lock.ExitWriteLock();
            }
        }
    }
}
