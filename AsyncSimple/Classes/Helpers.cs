using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSimple.Classes
{
    public static class Helpers
    {
        public static async IAsyncEnumerable<int> RangeAsync(this int start, int count, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {

            for (int index = 0; index < count; index++)
            {
                if (cancellationToken.IsCancellationRequested) cancellationToken.ThrowIfCancellationRequested();
                await Task.Delay(GlobalStuff.TimeSpan, cancellationToken);
                yield return start + index;
            }
        }

    }
}