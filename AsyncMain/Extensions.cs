using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMain
{
    static class Extensions
    {
        public static async IAsyncEnumerable<int> RangeAsync(this int start, int count, int delay, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (var index = 0; index < count; index++)
            {
                await Task.Delay(delay, cancellationToken);
                yield return start + index;
            }
        }
    }
}