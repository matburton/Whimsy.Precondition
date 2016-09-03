
using System;

using Whimsy.Precondition.Injection.Core.Injection;
using Whimsy.Precondition.Injection.Core.Logging;

namespace Whimsy.Precondition.Injection.Core
{
    public static class InjectorFactory
    {
        public static IAssemblyInjector CreateAssemblyInjector(ILog log)
        {
            if (log == null) throw new ArgumentNullException(nameof(log));

            return new PreconditionAssemblyInjector(log);
        }
    }
}