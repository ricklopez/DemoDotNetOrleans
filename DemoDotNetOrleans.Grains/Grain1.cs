using System.Threading.Tasks;
using DemoDotNetOrleans.Interfaces;
using Orleans;

namespace DemoDotNetOrleans.Grains
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    public class Grain1 : Grain, IGrain1
    {
        public Task<string> SayHello()
        {
            return Task.FromResult("Hello World");
        }
    }
}
