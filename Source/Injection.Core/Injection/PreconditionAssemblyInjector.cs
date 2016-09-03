
using System;

using Whimsy.Precondition.Injection.Core.Logging;

namespace Whimsy.Precondition.Injection.Core.Injection
{
    internal sealed class PreconditionAssemblyInjector : IAssemblyInjector
    {
        public PreconditionAssemblyInjector(ILog log)
        {
            if (log == null) throw new ArgumentNullException(nameof(log));

            _log = log;
        }

        private readonly ILog _log;
    }
}