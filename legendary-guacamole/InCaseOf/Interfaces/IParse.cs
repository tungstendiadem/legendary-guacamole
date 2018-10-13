using System;
using System.Collections.Generic;
using System.Text;

namespace InCaseOf.Interfaces
{
    interface INCaseOf<T>
    {
        // I don't think we are going to be event driven so maybe no delegates just methods
        Delegate Converter<StringInput, StringOutput>(StringInput input);
    }

    interface ITHas<in T>
    {
        Delegate Comparison<CharacterInput>(CharacterInput input);
    }
}
