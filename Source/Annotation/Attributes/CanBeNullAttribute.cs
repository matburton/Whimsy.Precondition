
using System;

namespace Whimsy.Precondition.Annotation.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class CanBeNullAttribute : Attribute {}
}